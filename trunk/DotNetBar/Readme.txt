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
1. copy c�c file dll d� thu m?c c:\program files\ dot net b? for win form
2. v� run -> regedit
->HKEY_CLASS_ROOT
->installer->assembly->global->t�m v� x�a DevComponents
3.C:\Program Files\Microsoft SDKs\Windows\v7.0A\bin
copy gacutil.exe v�o bin 
v�o c:\program files\ dot net bar forr winform
(nh?n shif chu?t ph?i ch?n open comand )
copy  for %i in (*.dll) do gacutil /i %i (chu?t ph?i paste)

by Snowfoxzx
2011-10-29


chinese:

1. �ӹ������ز���װDotNetBar����2011��10��28�����·����汾Ϊ10.1.0.0��
	http://www.devcomponents.com/dotnetbar/download.aspx
	
2. ��ѹDnbPatch.7z����ԭʼ��װ�ļ���

3. ��ע���༭����ɾ������λ��������DevComponents�����
	[HK_CLASSES_ROOT\Installer\Assemblies\Global]
	
4. ʹ��gacutil����ж��GAC������DevComponents��س��򼯡�

5. ��VS�����й��ߣ������ǰĿ¼ΪDotNetBar��װĿ¼��ִ����������������dll�ļ�ע�ᵽGAC�С�
	for %i in (*.dll) do gacutil /i %i
	
6. װ�������DotNetBar�ؼ�������ӵ�vs�����䡣

Snowfoxzx
2011-10-29