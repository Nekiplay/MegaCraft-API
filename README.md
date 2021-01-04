# MegaCraft-API

## API for minecraft server: mc.megacraft.org

**Using:**
```C#
MegaCraft.API.User user = new MegaCraft.API.User("nickname", CheckLicense: true);
if (user.Valid)
{
  if (user.License.Lisence)
  {
    Console.WriteLine("Ник игрока: " + user.Realname + " [Лицензия]");
    Console.WriteLine("UUID: " + user.License.UUID);
  }
  else
    Console.WriteLine("Ник игрока: " + user.Realname + " [Пиратка]");
    if (!string.IsNullOrEmpty(user.Staff))
      Console.WriteLine(user.Staff);
    Console.WriteLine("Уровень: " + user.Level);
    Console.WriteLine("Наиграл: " + user.Mtime.Days + "д. " + user.Mtime.Hours + "ч. " + user.Mtime.Minutes + "м. " + user.Mtime.Seconds + "с.");
    Console.WriteLine("");
    Console.WriteLine("Последный выход с сервера: " + user.Lastlogin.Days + "д. " + user.Lastlogin.Hours + "ч. " + user.Lastlogin.Minutes + "м. " + user.Lastlogin.Seconds + "с. назад");
    Console.WriteLine("Последний сервер: " + user.Lastserver);
    Console.WriteLine("");
    Console.WriteLine("МегаКойнов: " + MegaCraft.Utils.IntFormat(user.Balance));
    Console.WriteLine("");
    Console.WriteLine("Убийств: " + MegaCraft.Utils.IntFormat(user.Kills));
    Console.WriteLine("Смертей: " + MegaCraft.Utils.IntFormat(user.Deaths));
    Console.WriteLine("");
    Console.WriteLine("Побед: " + MegaCraft.Utils.IntFormat(user.Wins));
    Console.WriteLine("Поражений: " + MegaCraft.Utils.IntFormat(user.Losse));
    Console.WriteLine("");
    Console.WriteLine("Донат: " + user.Donate);
    Console.WriteLine("Префикс: " + user.Prefix);
    if (user.Clan.InTheClan)
    {
      Console.WriteLine("");
      Console.WriteLine("Клан: " + user.Clan.Name);
      Console.WriteLine("Участников: " + user.Clan.Members + "/" + user.Clan.MaxMembers);
      Console.WriteLine("Счет: " + user.Clan.Score);   
    }
    Console.WriteLine("");
    Console.WriteLine("Имунитеты: " + user.Immune.Standart + ", " + user.Immune.MImmune + ", " + user.Immune.SImmune);
    if (user.Ban.Banned)
    {
      Console.WriteLine("");
      Console.WriteLine("Забанен");
      Console.WriteLine("Причина бана: " + user.Ban.Reason);
      Console.WriteLine("Забанил: " + user.Ban.By);
      Console.WriteLine("Тип бана: " + user.Ban.Type);
    if (user.Ban.BanTime.Days != -1 && user.Ban.BanTime.Hours != -1 & user.Ban.BanTime.Minutes != -1 && user.Ban.BanTime.Seconds != -1)
    {
      Console.WriteLine("До разбана: " + user.Ban.BanTime.Days + "д. " + user.Ban.BanTime.Hours + "ч. " + user.Ban.BanTime.Minutes + "м. " + user.Ban.BanTime.Seconds + "с.");
    }
  }
}
else
{
  Console.WriteLine("Пользователь не найден");
}
```
