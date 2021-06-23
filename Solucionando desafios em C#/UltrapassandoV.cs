using System;

class MainClass {

  public static void Main () {
    var R = int.Parse(Console.ReadLine());
    var V = 0;
    var b = 0;
    var c = 1;

    do {

      V = int.Parse(Console.ReadLine());

    } while (R > V);
    
    b = R;
    while (b <= V) {
      c++;
      R += 1;
      b += R;
    }
    Console.WriteLine(c);
    
  }
}