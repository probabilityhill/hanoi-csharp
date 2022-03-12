using System;

class Hanoi {
  public void Move(int n, char from, char to, char other) {
    if(n >= 1) {
      Move(n - 1, from, other, to);
      Console.WriteLine("move disk {0} from {1} to {2}.", n, from, to);
      Move(n - 1, other, to, from);
    }
  }
}

class HanoiMain {
  public static void Main(string[] args) {
    Hanoi hanoi = new Hanoi();

    Console.Write("How many disks? ");
    int n = int.Parse(Console.ReadLine());

    // n枚のdiskをAからCへ移す
    hanoi.Move(n, 'A', 'C', 'B');
  }
}
