English:

1. Download and install DotNetBar from official website.(2011-10-28 release the new version 10.1.0.0)
	http://www.devcomponents.com/dotnetbar/download.aspx
	
2. Extract DnbPatch.7z and replace the original file.

3. Open RegEdit and delete all of DevComponents related items in
	[HK_CLASSES_ROOT\Installer\Assemblies\Global]

4. Use "gacutil" uninstall all of DevComponents related assemblies from GAC.

5. Open vs command prompt and change the current dir to the DotNetBar installation dir. 
execute the follow commad to register the patched dll to GAC.
	for %i in (*.dll) do gacutil /i %i
	
6. Add the patched DotNetBar controls to vs toolbox.

7. All done!

------------------*****-----------------------------
1. copy các file dll dô thu m?c c:\program files\ dot net b? for win form
2. vô run -> regedit
->HKEY_CLASS_ROOT
->installer->assembly->global->tìm và xóa DevComponents
3.C:\Program Files\Microsoft SDKs\Windows\v7.0A\bin
copy gacutil.exe vào bin 
vào c:\program files\ dot net bar forr winform
(nh?n shif chu?t ph?i ch?n open comand )
copy  for %i in (*.dll) do gacutil /i %i (chu?t ph?i paste)

by Snowfoxzx
2011-10-29


chinese:

1. ´Ó¹ÙÍøÏÂÔØ²¢°²×°DotNetBar¡££¨2011Äê10ÔÂ28ÈÕ×îĞÂ·¢²¼°æ±¾Îª10.1.0.0£©
	http://www.devcomponents.com/dotnetbar/download.aspx
	
2. ½âÑ¹DnbPatch.7z¸²¸ÇÔ­Ê¼°²×°ÎÄ¼ş¡£

3. ´ò¿ª×¢²á±í±à¼­Æ÷£¬É¾³ıÒÔÏÂÎ»ÖÃÖĞËùÓĞDevComponentsÏà¹ØÏî
	[HK_CLASSES_ROOT\Installer\Assemblies\Global]
	
4. Ê¹ÓÃgacutil¹¤¾ßĞ¶ÔØGACÖĞËùÓĞDevComponentsÏà¹Ø³ÌĞò¼¯¡£

5. ´ò¿ªVSÃüÁîĞĞ¹¤¾ß£¬±ä¸üµ±Ç°Ä¿Â¼ÎªDotNetBar°²×°Ä¿Â¼£¬Ö´ĞĞÏÂÁĞÃüÁî½«²¹¶¡ºóµÄdllÎÄ¼ş×¢²áµ½GACÖĞ¡£
	for %i in (*.dll) do gacutil /i %i
	
6. ×°²¹¶¡ºóµÄDotNetBar¿Ø¼şÖØĞÂÌí¼Óµ½vs¹¤¾ßÏä¡£

Snowfoxzx
2011-10-29