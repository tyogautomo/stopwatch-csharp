using System;

namespace ExerciseOne {
  class Program {
    static void Main(string[] args) {

      try {
        var stopwatch = new Stopwatch();

        stopwatch.Start();

        while (!stopwatch.IsEnded) {
          var isStopped = Console.ReadLine();
          if (isStopped == "stop") {
            stopwatch.Stop();

            while (true) {
              Console.WriteLine("Continue the stopwatch? (y / n)");
              var isContinue = Console.ReadLine();

              if (isContinue == "n") {
                stopwatch.IsEnded = true;
                break;
              } else if (isContinue == "y") {

                while (true) {
                  Console.WriteLine("Reset the stopwatch? (y / n)");
                  var isReset = Console.ReadLine();

                  if (isReset == "y") {
                    stopwatch.Reset();
                    stopwatch.Start();
                    break;
                  } else if (isReset == "n") {
                    stopwatch.Start();
                    break;
                  } else {
                    Console.WriteLine("Invalid reset input. Please type y or n");
                  }
                }
                break;
              } else {
                Console.WriteLine("Invalid continue input. Please type y or n");
              }
            }

          } else {
            Console.WriteLine("Invalid command.");
            continue;
          }
        }
      } catch (Exception err) {
        Console.WriteLine(err.Message);
      }

    }
  }
}
