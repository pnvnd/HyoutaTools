# DestinyRemake

## Source
All source code was copied from https://github.com/AdmiralCurtiss/HyoutaTools and modified to remove anything unrelated to Tales of Destiny DC.
HyoutaTools is originally a collection of functions to pack and unpack video game archives, as well as to extract data from them for GraceNote.
As well, icon was added to make the executable look cool.

## Compile Instructions
1. Open `DestinyRemake.sln` and build the solution, easy as that!

## Usage Instructions
1. `DestinyRemake.exe` to see available options
1. `DestinyRemake.exe unpack DAT.TBL DAT.BIN` to extract all files from `DAT.BIN` using `DAT.TBL`
1. `DestinyRemake.exe unpack MOV.TBL MOV.BIN` to extract all files from `MOV.BIN` using `MOV.TBL`
1. This is basically equivalent to `ToDDCTools_v1.1.exe unpack DAT.BIN DAT.TBL` but with no extensions or folder organization.  
1. `DestinyRemake.exe unmglk .\DAT.BIN.ex\0#####` to extract .sce file from MGLK file.
1. This is equivalent to `ToDDCTools_v1.1.exe unmglk #####` + `comptoe.exe -d1 0#####.sce #####.rsce` but without the other files inside MGLK

## Next Steps
1. Need to update DestinyRemake.exe to `PACK` files back into DAT.BIN and DAT.TBL and .MGLK
1. Need `unpack` to add extension to files and organize into folders
1. Need `unmglk` to also extract everything from MGLK files, not just SCE
1. Need `unmglk` to also use `comptoe.exe` to create RSCE files
