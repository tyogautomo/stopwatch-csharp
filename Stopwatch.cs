using System;

namespace ExerciseOne {

  public class Stopwatch {

    public DateTime StartTime { get; set; }
    public DateTime StopTime { get; set; }
    public TimeSpan TotalTime { get; set; } = new TimeSpan(0, 0, 0);
    public bool IsStarted { get; set; } = false;
    public bool IsEnded { get; set; } = false;

    public void Start() {
      if (!IsStarted) {
        Console.WriteLine("STARTED. Type 'stop' and press ENTER to stop the stopwatch.");
        IsStarted = true;
        StartTime = DateTime.Now;
      } else {
        throw new InvalidOperationException("Stopwatch is already started.");
      }
    }

    public void Stop() {
      if (IsStarted) {
        IsStarted = false;
        StopTime = DateTime.Now;
        var result = StopTime - StartTime;
        TotalTime += result;
        Console.WriteLine($"STOPED. Total duration: {TotalTime}");
      } else {
        throw new InvalidOperationException("Please start the stopwatch first.");
      }
    }

    public void Reset() {
      TotalTime = new TimeSpan(0, 0, 0);
    }
  }
}