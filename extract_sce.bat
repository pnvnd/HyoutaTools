REM Only do this for MGLK files (013550 to 014860) otherwise fail
for %%i in (.\DAT.BIN.ex\*) do DestinyRemake.exe Tales.DestinyRemake.MglkExtract.Extract %%i
pause