# MegaCraft-API

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/53e749024a1842deafccf7501775b27a)](https://www.codacy.com/gh/Nekiplay/MegaCraft-API/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=Nekiplay/MegaCraft-API&amp;utm_campaign=Badge_Grade)

[Nuget](https://www.nuget.org/packages/MegaAPILibrary)

## API for minecraft server: mc.megacraft.org

**Using /mtop megacoin:**
```C#
MegaAPILibrary.MegaCraft.API.Mtop.MegaCoins mtopmegacoins = new MegaCraft.API.Mtop.MegaCoins();
foreach (MegaAPILibrary.MegaCraft.API.Mtop.MegaCoins.User user in mtopmegacoins.users)
{
  Console.WriteLine("Ник: " + user.name);
  Console.WriteLine("Баланс: " + MegaAPILibrary.MegaCraft.Utils.IntFormat(user.balance));
  Console.WriteLine("");
}
```

**Using /mtop clans:**

```C#
MegaAPILibrary.MegaCraft.API.Mtop.Clans mtopclans = new MegaCraft.API.Mtop.Clans();
foreach (MegaAPILibrary.MegaCraft.API.Mtop.Clans.Clan clan in mtopclans.clans)
{
  Console.WriteLine("Название клана: " + MegaAPILibrary.MegaCraft.Utils.RemoveColor(clan.name));
  Console.WriteLine("Ранг клана: " + clan.rank);
  Console.WriteLine("Владелец клана: " + clan.leader);
  Console.WriteLine("");
}
```

**Using user statistic:**

```C#
MegaAPILibrary.MegaCraft.API.User user = new MegaAPILibrary.MegaCraft.API.User("Neki_play1", true);
if (user.Valid)
{
  if (user.license.Lisence)
  {
    Console.WriteLine("Ник игрока: " + user.realname + " [Лицензия]");
    Console.WriteLine("UUID: " + user.license.UUID);
  }
  else
  {
    Console.WriteLine("Ник игрока: " + user.realname + " [Пиратка]");
  }
  if (!string.IsNullOrEmpty(user.staff))
  {
    Console.WriteLine(user.staff);
  }
  Console.WriteLine("");
  Console.WriteLine("Уровень: " + user.level);
  Console.WriteLine("Наиграл: " + user.mtime.Days + "д. " + user.mtime.Hours + "ч. " + user.mtime.Minutes + "м. " + user.mtime.Seconds + "с.");
  Console.WriteLine("");
  Console.WriteLine("Последный выход с сервера: " + user.lastlogin.Days + "д. " + user.lastlogin.Hours + "ч. " + user.lastlogin.Minutes + "м. " + user.lastlogin.Seconds + "с. назад");
  Console.WriteLine("Последний сервер: " + user.lastserver);
  Console.WriteLine("");
  Console.WriteLine("МегаКойнов: " + MegaCraft.Utils.IntFormat(user.balance));
  Console.WriteLine("");
  Console.WriteLine("Убийств: " + MegaCraft.Utils.IntFormat(user.kills));
  Console.WriteLine("Смертей: " + MegaCraft.Utils.IntFormat(user.deaths));
  Console.WriteLine("");
  Console.WriteLine("Побед: " + MegaCraft.Utils.IntFormat(user.wins));
  Console.WriteLine("Поражений: " + MegaCraft.Utils.IntFormat(user.losse));
  Console.WriteLine("");
  Console.WriteLine("Донат: " + MegaAPILibrary.MegaCraft.Utils.RemoveColor(user.donate));
  Console.WriteLine("Префикс: " + MegaAPILibrary.MegaCraft.Utils.RemoveColor(user.prefix));
  if (user.clan.InTheClan)
  {
    Console.WriteLine("");
    Console.WriteLine("Клан: " + MegaAPILibrary.MegaCraft.Utils.RemoveColor(user.clan.Name));
    Console.WriteLine("Участников: " + user.clan.Members + "/" + user.clan.MaxMembers);
    Console.WriteLine("Счет: " + user.clan.Score);
  }
  Console.WriteLine("");
  Console.WriteLine("Имунитеты: " + user.immune.Standart + ", " + user.immune.MImmune + ", " + user.immune.SImmune);
  if (user.ban.Banned)
  {
    Console.WriteLine("");
    Console.WriteLine("Забанен");
    Console.WriteLine("Причина бана: " + user.ban.Reason);
    Console.WriteLine("Забанил: " + user.ban.By);
    Console.WriteLine("Тип бана: " + user.ban.Type);
    if (user.ban.BanTime.Days != -1 && user.ban.BanTime.Hours != -1 & user.ban.BanTime.Minutes != -1 && user.ban.BanTime.Seconds != -1)
    {
      Console.WriteLine("До разбана: " + user.ban.BanTime.Days + "д. " + user.ban.BanTime.Hours + "ч. " + user.ban.BanTime.Minutes + "м. " + user.ban.BanTime.Seconds + "с.");
    }
  }
}
else
{
  Console.WriteLine("Пользователь не найден");
}
Console.ReadLine();
```
