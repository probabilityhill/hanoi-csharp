# ハノイの塔

## アルゴリズム
```Text
GOAL: move n disks from A to C

move n-1 disks from A to B -> 再帰
move disk n from A to C
move n-1 disks from B to C -> 再帰
```
<img alt="Tower of hanoi" src="https://user-images.githubusercontent.com/74280232/158025699-ec93796c-3322-48d9-b9be-5e10b7249d8c.png" width=300>

## n=3の例
```Text
How many disks? -> 3

move disk 1 from A to C.
move disk 2 from A to B.
move disk 1 from C to B.
move disk 3 from A to C.
move disk 1 from B to A.
move disk 2 from B to C.
move disk 1 from A to C.
```
