using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace MegaAPILibrary
{
    public class MegaCraft
    {
        public static class Utils
        {
            public static string RemoveColor(string text)
            {
                text = text.Replace("&0", "").Replace("&1", "").Replace("&2", "").Replace("&3", "").Replace("&4", "").Replace("&5", "").Replace("&6", "").Replace("&7", "").Replace("&8", "").Replace("&9", "");
                text = text.Replace("&a", "").Replace("&b", "").Replace("&c", "").Replace("&d", "").Replace("&e", "").Replace("&f", "");
                text = text.Replace("&k", "").Replace("&l", "").Replace("&m", "").Replace("&n", "").Replace("&o", "").Replace("&r", "");
                // 2
                text = text.Replace("§0", "").Replace("§1", "").Replace("§2", "").Replace("§3", "").Replace("§4", "").Replace("§5", "").Replace("§6", "").Replace("§7", "").Replace("§8", "").Replace("§9", "");
                text = text.Replace("§a", "").Replace("§b", "").Replace("§c", "").Replace("§d", "").Replace("§e", "").Replace("§f", "");
                text = text.Replace("§k", "").Replace("§l", "").Replace("§m", "").Replace("§n", "").Replace("§o", "").Replace("§r", "");
                // 3
                text = text.Replace("&A", "").Replace("&B", "").Replace("&C", "").Replace("&D", "").Replace("&E", "").Replace("&F", "");
                text = text.Replace("&K", "").Replace("&L", "").Replace("&M", "").Replace("&N", "").Replace("&O", "").Replace("&R", "");
                text = text.Replace("§A", "").Replace("§B", "").Replace("§C", "").Replace("§D", "").Replace("§E", "").Replace("§F", "");
                text = text.Replace("§K", "").Replace("§L", "").Replace("§M", "").Replace("§N", "").Replace("§O", "").Replace("§R", "");
                return text;
            }
            public static int ConvertSectoDay(int n)
            {
                int day = n / (24 * 3600);
                return day;
            }
            public static int ConvertSectoHour(int n)
            {
                n = n % (24 * 3600);
                int hour = n / 3600;
                return hour;
            }
            public static int ConvertSectoMinutes(int n)
            {
                n = n % (24 * 3600);
                n %= 3600;
                int minutes = n / 60;
                return minutes;
            }
            public static int ConvertSectoSeconds(int n)
            {
                n = n % (24 * 3600);
                n %= 3600;
                n %= 60;
                int seconds = n;

                return seconds;
            }
            public static string IntFormat(int value)
            {
                return IntFormat(value.ToString());
            }
            public static string IntFormat(string text)
            {
                int countbalance = text.ToCharArray().Length;
                if (countbalance > 12 & countbalance >= 15)
                {
                    int formatedbalanceT = Convert.ToInt32(Regex.Match(text, "(.*)[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]").Groups[1].Value);
                    int formatedbalanceB = Convert.ToInt32(Regex.Match(text, formatedbalanceT + "(.*)[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]").Groups[1].Value);
                    int formatedbalanceM = Convert.ToInt32(Regex.Match(text, formatedbalanceB + "(.*)[0-9][0-9][0-9][0-9][0-9][0-9]").Groups[1].Value);
                    int formatedbalanceK = Convert.ToInt32(Regex.Match(text, formatedbalanceM + "(.*)[0-9][0-9][0-9]").Groups[1].Value);
                    text = text + " [" + formatedbalanceT + "]T, " + "[" + formatedbalanceB + "]B, " + "[" + formatedbalanceM + "]M, " + "[" + formatedbalanceK + "]K";
                }
                else if (countbalance > 9)
                {
                    int formatedbalanceB = Convert.ToInt32(Regex.Match(text, "(.*)[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]").Groups[1].Value);
                    int formatedbalanceM = Convert.ToInt32(Regex.Match(text, formatedbalanceB + "(.*)[0-9][0-9][0-9][0-9][0-9][0-9]").Groups[1].Value);
                    int formatedbalanceK = Convert.ToInt32(Regex.Match(text, formatedbalanceM + "(.*)[0-9][0-9][0-9]").Groups[1].Value);
                    text = text + " [" + formatedbalanceM + "]B, " + "[" + formatedbalanceK + "]M, " + "[" + formatedbalanceK + "]K";
                }
                else if (countbalance > 6)
                {
                    int formatedbalanceM = Convert.ToInt32(Regex.Match(text, "(.*)[0-9][0-9][0-9][0-9][0-9][0-9]").Groups[1].Value);
                    int formatedbalanceK = Convert.ToInt32(Regex.Match(text, formatedbalanceM + "(.*)[0-9][0-9][0-9]").Groups[1].Value);
                    text = text + " [" + formatedbalanceM + "]M, " + "[" + formatedbalanceK + "]K";
                }
                else if (countbalance > 3)
                {
                    int formatedbalanceK = Convert.ToInt32(Regex.Match(text, "(.*)[0-9][0-9][0-9]").Groups[1].Value);
                    text = text + " [" + formatedbalanceK + "]K";
                }
                return text;
            }
        }
        public class API
        {
            public class User
            {
                public class _Mtime_
                {
                    public int Days;
                    public int Hours;
                    public int Minutes;
                    public int Seconds;
                    public _Mtime_(int Days, int Hours, int Minutes, int Seconds)
                    {
                        this.Days = Days;
                        this.Hours = Hours;
                        this.Minutes = Minutes;
                        this.Seconds = Seconds;
                    }
                }
                public class _Lastlogin_
                {
                    public int Days;
                    public int Hours;
                    public int Minutes;
                    public int Seconds;

                    public _Lastlogin_(int Days, int Hours, int Minutes, int Seconds)
                    {
                        this.Days = Days;
                        this.Hours = Hours;
                        this.Minutes = Minutes;
                        this.Seconds = Seconds;
                    }
                }
                public class _Ban_
                {
                    public string By;
                    public string Reason;
                    public string Type;

                    public bool Banned = false;

                    public _Mtime_ BanTime;

                    public class _Mtime_
                    {
                        public int Days;
                        public int Hours;
                        public int Minutes;
                        public int Seconds;
                        public _Mtime_(int Days, int Hours, int Minutes, int Seconds)
                        {
                            this.Days = Days;
                            this.Hours = Hours;
                            this.Minutes = Minutes;
                            this.Seconds = Seconds;
                        }
                    }
                }


                public class _Immune_
                {
                    public bool Standart = false;
                    public bool MImmune = false;
                    public bool SImmune = false;

                    public _Immune_(bool one, bool two, bool tree)
                    {
                        this.Standart = one;
                        this.MImmune = two;
                        this.SImmune = tree;
                    }
                }
                public class _License_
                {
                    public bool Lisence;
                    public string UUID;
                }
                public class _Clan_
                {
                    public bool InTheClan;
                    public string Name;
                    public bool IsModer;
                    public bool IsLeader;
                    public int Score;
                    public int Members;
                    public int MaxMembers;
                }
                public string Realname;
                public string Staff;
                public int Level;
                public int Balance;
                public _Mtime_ Mtime;

                public _Lastlogin_ Lastlogin;
                public string Lastserver;

                public int Kills;
                public int Deaths;

                public int Wins;
                public int Losse;

                public string Prefix;
                public string Donate;
                public double Multiplier;

                public _Clan_ Clan;

                public _Immune_ Immune;

                public _Ban_ Ban;

                public _License_ License;
                public double GetMultiDonate(string donete)
                {
                    if (donete == "&e► &4&lＯＰ&e ◄ &4&l")
                    {
                        return 100;
                    }
                    else if (donete == "&e『&4&lＳｐｏｎｓｏｒ&e』&4&l")
                    {
                        return 50;
                    }
                    else if (donete == "&e&l『&4&lГлава сервера&e&l』&4&l")
                    {
                        return 30;
                    }
                    else if (donete == "&e&l『&4&lПрезидент сервера&e&l』&4&l")
                    {
                        return 26;
                    }
                    else if (donete == "&e&l『&4&lВладелец сервера&e&l』&4&l")
                    {
                        return 24;
                    }
                    else if (donete == "&e『&4&lСоВладелец&e』&4&l")
                    {
                        return 22;
                    }
                    else if (donete == "&e『&4&lОснователь сервера&e』&4&l")
                    {
                        return 20;
                    }
                    else if (donete == "&e『&4&lГл. Администратор&e』&4&l")
                    {
                        return 18;
                    }
                    else if (donete == "&e『&4&lСт. Администратор&e』&4&l")
                    {
                        return 16;
                    }
                    else if (donete == "&e『&4&lАдминистратор&e』&4&l")
                    {
                        return 14;
                    }
                    else if (donete == "&e『&4&lС&c&lМодер&e』&4&l")
                    {
                        return 12;
                    }
                    else if (donete == "&e『&4&lБОЛЬШОЙ БОСС&e』&4&l")
                    {
                        return 10;
                    }
                    else if (donete == "&c『&4&l&nБОГ&c』&4&l")
                    {
                        return 8;
                    }
                    else if (donete == "&8[&6Игрок&8] &7")
                    {
                        return 7;
                    }
                    else if (donete == "&c『&2&lВладелец&c』&4&l")
                    {
                        return 6.5;
                    }
                    else if (donete == "&c『&4&lОснователь&c』&4&l")
                    {
                        return 6;
                    }
                    else if (donete == "&6『&e&lСоздатель&6』&2&l")
                    {
                        return 5.5;
                    }
                    else if (donete == "&6『&d&lОператор&6』&d&l")
                    {
                        return 5;
                    }
                    else if (donete == "&6『&c&lГл. Админ&6』&c&l")
                    {
                        return 4.5;
                    }
                    else if (donete == "&d『&5Лорд&d』&5")
                    {
                        return 4;
                    }
                    else if (donete == "&e『&cАдмин&e』&c")
                    {
                        return 3.5;
                    }
                    else if (donete == "&e『&3Модер&e』&3")
                    {
                        return 3;
                    }
                    else if (donete == "&e『&bКреатив&e』&b")
                    {
                        return 2.5;
                    }
                    else if (donete == "&e『&dПремиум&e』&d")
                    {
                        return 2;
                    }
                    else if (donete == "&e『&aВип&e』&2")
                    {
                        return 1.5;
                    }
                    else
                    {
                        return 0;
                    }
                    }

                public User(string Nickname, bool CheckLicense)
                {
                    if (!string.IsNullOrEmpty(Nickname))
                    {
                        try
                        {
                            using (WebClient wc = new WebClient())
                            {
                                wc.Encoding = Encoding.UTF8;

                                string Response = wc.DownloadString("http://megacraft.org/api/v1/users/" + Nickname);
                                this.Realname = Regex.Match(Response, "\"realname\": \"(.*)\",").Groups[1].Value;

                                string staff = Regex.Match(Response, "\"staff\": \"(.*)\",").Groups[1].Value;
                                if (staff != "")
                                {
                                    this.Staff = staff;
                                }
                                string level = Regex.Match(Response, "\"level\": \"(.*)\",").Groups[1].Value;
                                if (level != string.Empty)
                                {
                                    this.Level = int.Parse(level);
                                }
                                else
                                {
                                    level = Regex.Match(Response, "\"level\": (.*),").Groups[1].Value;
                                    this.Level = int.Parse(level);
                                }
                                this.Balance = int.Parse(Regex.Match(Response, "\"balance\": \"(.*)\",").Groups[1].Value);
                                string mtime = Regex.Match(Response, "\"mtime\": \"(.*)\",").Groups[1].Value;
                                if (mtime != "")
                                {
                                    int days = MegaCraft.Utils.ConvertSectoDay(Convert.ToInt32(mtime));
                                    int hours = MegaCraft.Utils.ConvertSectoHour(Convert.ToInt32(mtime));
                                    int minutes = MegaCraft.Utils.ConvertSectoMinutes(Convert.ToInt32(mtime));
                                    int seconds = MegaCraft.Utils.ConvertSectoSeconds(Convert.ToInt32(mtime));
                                    this.Mtime = new _Mtime_(days, hours, minutes, seconds);
                                }

                                string lastlogin = Regex.Match(Response, "\"lastlogin\": \"(.*)\",").Groups[1].Value;
                                // Unix timestamp is seconds past epoch
                                TimeZoneInfo moscowZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
                                DateTime localtime = DateTime.Now;
                                DateTime localmoscowTime = TimeZoneInfo.ConvertTime(localtime, moscowZone);
                                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                                dtDateTime = dtDateTime.AddSeconds(int.Parse(lastlogin)).ToLocalTime();
                                DateTime moscowTime = TimeZoneInfo.ConvertTime(dtDateTime, moscowZone);
                                TimeSpan interval = localmoscowTime.AddSeconds(38) - moscowTime;


                                this.Lastlogin = new _Lastlogin_(interval.Days, interval.Hours, interval.Minutes, interval.Seconds);
                                this.Lastserver = Regex.Match(Response, "\"lastserver\": \"(.*)\",").Groups[1].Value;

                                this.Kills = int.Parse(Regex.Match(Response, "\"kills\": \"(.*)\",").Groups[1].Value);
                                this.Deaths = int.Parse(Regex.Match(Response, "\"deaths\": \"(.*)\",").Groups[1].Value);

                                this.Wins = int.Parse(Regex.Match(Response, "\"wins\": \"(.*)\",").Groups[1].Value);
                                this.Losse = int.Parse(Regex.Match(Response, "\"losse\": \"(.*)\",").Groups[1].Value);

                                this.Prefix = Regex.Match(Response, "\"prefix\": \"(.*)\",").Groups[1].Value.Replace(@"\/", "/");
                                this.Donate = Regex.Match(Response, "\"groupprefix\": \"(.*)\",").Groups[1].Value;
                                this.Multiplier = GetMultiDonate(Donate);
                                bool immunone = bool.Parse(Regex.Match(Response, "\"immun\": (.*),").Groups[1].Value);
                                bool immuntwo = bool.Parse(Regex.Match(Response, "\"mimmun\": (.*),").Groups[1].Value);
                                bool immuntree = bool.Parse(Regex.Match(Response, "\"simmun\": (.*),").Groups[1].Value);

                                this.Immune = new _Immune_(immunone, immuntwo, immuntree);

                                string inclan = Regex.Match(Response, "\"clan\": (.*)").Groups[1].Value;
                                if (inclan != "false")
                                {
                                    this.Clan = new _Clan_();
                                    this.Clan.InTheClan = true;
                                    this.Clan.Name = Regex.Match(Response, "\"clan_name\": \"(.*)\",").Groups[1].Value;
                                    this.Clan.IsLeader = bool.Parse(Regex.Match(Response, "\"isLeader\": (.*),").Groups[1].Value);
                                    this.Clan.IsModer = bool.Parse(Regex.Match(Response, "\"isModer\": (.*),").Groups[1].Value);
                                    string score = Regex.Match(Response, "\"score\": \"(.*)\",").Groups[1].Value;
                                    if (score != "")
                                    {
                                        this.Clan.Score = int.Parse(score);
                                    }
                                    else
                                    {
                                        this.Clan.Score = 0;
                                    }

                                    string members = Regex.Match(Response, "\"members\": \"(.*)\",").Groups[1].Value;
                                    if (members != "")
                                    {
                                        this.Clan.Members = int.Parse(members);
                                    }
                                    else
                                    {
                                        this.Clan.Members = 0;
                                    }

                                    string maxmembers = Regex.Match(Response, "\"max_members\": \"(.*)\",").Groups[1].Value;
                                    if (maxmembers != "")
                                    {
                                        this.Clan.MaxMembers = int.Parse(maxmembers);
                                    }
                                    else
                                    {
                                        this.Clan.MaxMembers = 20;
                                    }
                                }
                                else
                                {
                                    this.Clan = new _Clan_
                                    {
                                        InTheClan = false,
                                    };

                                }

                                string bantype = Regex.Match(Response, "\"type\": \"(.*)\",").Groups[1].Value;
                                if (bantype != string.Empty)
                                {
                                    string banby = Regex.Match(Response, "\"bannedby\": \"(.*)\",").Groups[1].Value;
                                    string banreason = Regex.Match(Response, "\"reason\": \"(.*)\"").Groups[1].Value.Replace(@"\/", "/");

                                    this.Ban = new _Ban_ { Type = bantype, By = banby, Reason = banreason, Banned = true };

                                    string timeleft = Regex.Match(Response, "\"timeleft\": (.*)").Groups[1].Value;
                                    if (timeleft != string.Empty)
                                    {
                                        this.Ban.BanTime = new _Ban_._Mtime_(Utils.ConvertSectoDay(Convert.ToInt32(timeleft)), Utils.ConvertSectoHour(Convert.ToInt32(timeleft)), Utils.ConvertSectoMinutes(Convert.ToInt32(timeleft)), Utils.ConvertSectoSeconds(Convert.ToInt32(timeleft)));
                                    }
                                    else
                                    {
                                        this.Ban.BanTime = new _Ban_._Mtime_(-1, -1, -1, -1);
                                    }
                                }
                                else
                                {
                                    this.Ban = new _Ban_ { Banned = false };
                                }

                                this.License = new _License_
                                {
                                    Lisence = false,
                                    UUID = "",
                                };
                            }
                            if (CheckLicense)
                            {
                                using (WebClient wc2 = new WebClient())
                                {
                                    string Response2 = wc2.DownloadString("https://api.mojang.com/users/profiles/minecraft/" + Realname);
                                    string uuid = Regex.Match(Response2, "\"id\":\"(.*)\"}").Groups[1].Value;
                                    if (!string.IsNullOrEmpty(uuid))
                                    {
                                        this.License = new _License_
                                        {
                                            Lisence = true,
                                            UUID = uuid,
                                        };
                                    }
                                    else
                                    {
                                        this.License = new _License_
                                        {
                                            Lisence = false,
                                            UUID = uuid,
                                        };
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                }

                public bool Valid
                {
                    get
                    {
                        if (!string.IsNullOrEmpty(this.Realname))
                        {
                            return true;
                        }
                        else return false;
                    }
                }
            }
        }
    }
}
