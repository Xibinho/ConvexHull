#include %A_LineFile%\..\CLR.ahk
asm := CLR_LoadLibrary("ConvexHull.dll")
GrahamScanner := asm.CreateInstance("ConvexHull.GrahamScan")

pl := asm.CreateInstance("ConvexHull.PointsList")
pl.Add(9, 1)
pl.Add(4, 3)
pl.Add(4, 5)
pl.Add(3, 2)
pl.Add(14, 2)
pl.Add(4, 12)
pl.Add(4, 10)
pl.Add(5, 6)
pl.Add(10, 2)
pl.Add(1, 2)
pl.Add(1, 10)
pl.Add(5, 2)
pl.Add(11, 2)
pl.Add(4, 11)
pl.Add(12, 4)
pl.Add(3, 1)
pl.Add(2, 6)
pl.Add(2, 4)
pl.Add(7, 8)
pl.Add(5, 5)
result := GrahamScanner.convexHull(pl.Points)

str := "HULL:`n"
Loop % result.MaxIndex() + 1 ; Returned array from C# is 0-based, not 1-based
{
	str .= result[A_Index - 1].X ", " result[A_Index - 1].Y "`n"
}
msgbox % str