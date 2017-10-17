# Настройка ModOrganizer SKYGS
Исходный код программы для настройки программы ModOrganizer для сборки SKYGS.
![N|Solid](http://i89.fastpic.ru/big/2017/1017/ba/a3d9dd6d9d689749e2cd7e39fce279ba.png)

Программа меняет настройки ModOrganizer.ini. В итоге, если вы установили/скопировали/перенесли Скайрим в любую папку, вы можете легко настроить пути к необходимым программам.

Схема работы простая. Программа переопределяет настройки файла ModOrganizer.ini таким образом:
```c#
//GamePath
ini.WriteValue("gamePath", "General", skyPath);

//SKSE
ini.WriteValue("5\\binary", "customExecutables", skyPath + "/skse_loader.exe");
ini.WriteValue("5\\workingDirectory", "customExecutables", skyPath);

//java
ini.WriteValue("5\\binary", "customExecutables", javaPath); 
ini.WriteValue("5\\workingDirectory", "customExecutables", moPath + "/mods/Dual Sheath Redux/SkyProc l Sheath Redux Patch");

//TES5Edit
ini.WriteValue("6\\binary", "customExecutables", skyPath + "/TES5Edit.exe");
ini.WriteValue("6\\workingDirectory", "customExecutables", skyPath);

//FNIS
ini.WriteValue("4\\binary", "customExecutables", moPath + tools/GenerateFNIS_for_Users/GenerateFNISforUsers.exe");
ini.WriteValue("4\\workingDirectory", "customExecutables", moPath + "/mods/Fnis/tools/GenerateFNIS_for_Users");

//Wrye Bash
ini.WriteValue("7\\binary", "customExecutables", skyPath + "/Mopy/Wrye Bash.exe");
ini.WriteValue("7\\workingDirectory", "customExecutables", skyPath + "/Mopy");

//CalinteTools
ini.WriteValue("8\\binary", "customExecutables", moPath + "/mods/UN7B/CalienteTools/BodySlide/BodySlide.exe");
ini.WriteValue("8\\workingDirectory", "customExecutables", moPath + "/mods/UN7B/CalienteTools/BodySlide");

//FNIS7
ini.WriteValue("9\\binary", "customExecutables", moPath + /tools/GenerateFNIS_for_Users/GenerateFNISforUsers.exe");
ini.WriteValue("9\\workingDirectory", "customExecutables", moPath + "/mods/FNIS7/tools/GenerateFNIS_for_Users");

//CalinteTools
ini.WriteValue("10\\binary", "customExecutables", skyPath + "/PoserDataGen/PoserDataGen.exe");
ini.WriteValue("10\\workingDirectory", "customExecutables", skyPath + "/PoserDataGen/");

//recentDirectories
ini.WriteValue("1\\directory", "recentDirectories", skyPath + "/PoserDataGen/");
ini.WriteValue("2\\directory", "recentDirectories", skyPath);
```

Интерфейс программы:
![N|Solid](http://i89.fastpic.ru/big/2017/1017/1e/35bd5e5afa4c28a1c06c90626404471e.png)