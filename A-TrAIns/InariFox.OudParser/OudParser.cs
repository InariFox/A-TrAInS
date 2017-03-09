using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace InariFox.OudParser
{
    public class OudParser
    {
        private List<string> ouddata;
        private XmlDocument document;

        // trimメソッドの除外条件
        string[] trimlist =
        {
            "Ekijikokukeisiki=", "Kyoukaisen=", "StopMarkDrawType=",
            "DiagramRessyajouhouHyoujiKudari=", "DiagramRessyajouhouHyoujiKudari=",
            "Ryakusyou=", "JikokuhyouFontIndex=", "DiagramSenColor=", "DiagramSenStyle=",
            "KitenJikoku=", "DiagramDgrYZahyouKyoriDefault=", "DiagramRessyajouhouHyoujiNobori=",
            "JikokuhyouFont=", "JikokuhyouVFont=", "DiaEkimeiFont=", "DiaJikokuFont=",
            "DiaRessyaFont=", "CommentFont=", "DiaMojiColor=", "DiaHaikeiColor=",
            "DiaRessyaColor=", "DiaJikuColor=", "EkimeiLength=", "JikokuhyouRessyaWidth=",
            "FileTypeAppComment=", "FileType=", ".", "DiagramSenIsBold="
        };

        public OudParser()
        {
            ouddata = null;
            document = null;
        }

        public bool load(string source)
        {
            bool result = false;

            List<string> data = source.Replace("\r\n", "\n").Split('\n').ToList();
            if (data[0].Contains("FileType=OuDia"))
            {
                ouddata = trim(data);
                result = true;
            }

            return result;
        }

        private List<string> trim(List<string> source)
        {
            List<string> d = source.ToList();

            for (int i = d.Count - 1; i >= 0; i--)
            {
                if (trimlist.Any(d[i].Contains) && !Regex.IsMatch(d[i], @"^Comment="))
                {
                    d.Remove(d[i]);
                }
            }

            return d;
        }

        public void convert()
        {
            document = new XmlDocument();
            XmlDeclaration declaration = document.CreateXmlDeclaration("1.0", "UTF-8", null);  // XML宣言
            document.AppendChild(declaration);

            XmlElement root = document.CreateElement("line");
            XmlElement stations = document.CreateElement("stations");
            XmlElement trains = document.CreateElement("trains");
            XmlElement diagrams = document.CreateElement("diagrams");
            XmlElement comment = document.CreateElement("comment");

            List<string> d = getlist();
            for (int i = 0; i < d.Count; i++)
            {
                //- 路線名
                if (d[i].Contains("Rosenmei"))
                {
                    root.SetAttribute("name", d[i].Split('=')[1]);
                }

                //- 駅名
                if (d[i].Contains("Ekimei="))
                {
                    XmlElement station = document.CreateElement("station");  // ルート要素
                    station.InnerText = d[i].Split('=')[1];
                    if (d[i + 1].Contains("Ekikibo_Ippan")) { station.SetAttribute("type", "0"); }
                    else if (d[i + 1].Contains("Ekikibo_Syuyou")) { station.SetAttribute("type", "1"); }
                    else { station.SetAttribute("type", "-1"); }

                    stations.AppendChild(station);
                    i++;
                }

                //- 種別名
                if (d[i].Contains("Syubetsumei="))
                {
                    XmlElement train = document.CreateElement("train");  // ルート要素
                    train.InnerText = d[i].Split('=')[1];
                    train.SetAttribute("color", d[++i].Split('=')[1].Substring(2));

                    trains.AppendChild(train);
                }

                //- ダイヤ
                if (d[i].Contains("DiaName="))
                {
                    string dianame = d[i].Split('=')[1];
                    XmlElement diaD = document.CreateElement("diagram");
                    XmlElement diaU = document.CreateElement("diagram");

                    diaD.SetAttribute("name", dianame);
                    diaD.SetAttribute("direction", "down");
                    diaU.SetAttribute("name", dianame);
                    diaU.SetAttribute("direction", "up");

                    bool flag = true;
                    while (flag)
                    {
                        #region ダイヤグラムセクション解析
                        if (d[i + 1].Contains("Houkou="))
                        {
                            i++;
                            XmlElement track = document.CreateElement("track");
                            if (d[i].Contains("Kudari") || d[i].Contains("Nobori"))
                            {
                                // true:下り false:上り
                                bool is_down = true;
                                if (d[i].Contains("Nobori")) { is_down = false; }

                                track.SetAttribute("train_type", d[++i].Split('=')[1]);
                                if (d[i + 1].Contains("Ressyabangou=")) { track.SetAttribute("id", d[++i].Split('=')[1]); }
                                if (d[i + 1].Contains("Ressyamei=")) { track.SetAttribute("name", d[++i].Split('=')[1]); }
                                if (d[i + 1].Contains("Gousuu=")) { track.SetAttribute("id", d[++i].Split('=')[1]); }
                                if (d[i + 1].Contains("EkiJikoku="))
                                {
                                    List<string> dia = d[++i].Split('=')[1].Split(',').ToList();
                                    for (int j = 0; j < dia.Count; j++)
                                    {
                                        XmlElement departunes = document.CreateElement("departunes");
                                        #region IF:その駅を発着するかどうか
                                        if (dia[j].Contains("1;"))
                                        {
                                            departunes.SetAttribute("station", j.ToString());
                                            departunes.SetAttribute("stop", "1");

                                            if (dia[j].Split(';')[1].Contains("/"))
                                            {
                                                string[] dept = dia[j].Split(';')[1].Split('/');
                                                XmlElement arrival = document.CreateElement("arrival");
                                                arrival.InnerText = dept[0];
                                                departunes.AppendChild(arrival);

                                                if (!dept[1].Equals(""))
                                                {
                                                    XmlElement departune = document.CreateElement("departune");
                                                    departune.InnerText = dept[1];
                                                    departunes.AppendChild(departune);
                                                }

                                            }
                                            else
                                            {
                                                XmlElement departune = document.CreateElement("departune");
                                                departune.InnerText = dia[j].Split(';')[1];
                                                departunes.AppendChild(departune);
                                            }
                                        }
                                        else
                                        {
                                            departunes.SetAttribute("station", j.ToString());

                                            if (!string.IsNullOrEmpty(dia[j])) { departunes.SetAttribute("stop", dia[j]); }
                                            else { departunes.SetAttribute("stop", "3"); }
                                        }
                                        #endregion
                                        track.AppendChild(departunes);
                                    }
                                }
                                if (d[i + 1].Contains("Bikou="))
                                {
                                    XmlElement trackmemo = document.CreateElement("memo");
                                    trackmemo.InnerText = d[++i].Split('=')[1];
                                    track.AppendChild(trackmemo);
                                }

                                if (is_down) { diaD.AppendChild(track); }
                                else { diaU.AppendChild(track); }
                            }
                            else { flag = false; }
                        }
                        else { flag = false; }
                        #endregion
                    }

                    diagrams.AppendChild(diaD);
                    diagrams.AppendChild(diaU);
                }

                //- その他コメント類
                if (d[i].Contains(@"Comment="))
                {
                    comment.InnerText = d[i].Split('=')[1];
                }
            }

            root.AppendChild(stations);
            root.AppendChild(trains);
            root.AppendChild(diagrams);
            root.AppendChild(comment);
            document.AppendChild(root);
        }

        public List<string> getlist()
        {
            return ouddata;
        }

        public XmlDocument getXml()
        {
            return document;
        }
    }
}