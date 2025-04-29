namespace FacadeMethodDesignPatternExercise;


public class DVDPlayer
{
    public void On() => Console.WriteLine("DVD player is on");
    public void Play(string movie) => Console.WriteLine($"Playing {movie}");
    public void Off() => Console.WriteLine("DVD player OFF");
}

public class Projector
{
    public void On() => Console.WriteLine("Projector is on");
    public void Off() => Console.WriteLine("Projector OFF");
    public void WideScreenMode() => Console.WriteLine("Projector in widescreen mode");
}

public class SurroundSound
{
    public void On() => Console.WriteLine("Surround sound is on");
    public void SetVolume(int volume) => Console.WriteLine($"Surround sound volume set to {volume}");
    public void Off() => Console.WriteLine("Surround sound OFF");
}


public class TheaterLights
{
    public void Dim(int level) => Console.WriteLine($"Theater lights dimmed to {level}%");
    public void On() => Console.WriteLine("Theater lights are on");
}

public class HomeTheaterFacade
{
    private readonly  DVDPlayer _dvdPlayer;
    private readonly Projector _projector;
    private readonly SurroundSound _surroundSound;
    private readonly TheaterLights _theaterLights;
    public HomeTheaterFacade(DVDPlayer dvdPlayer, Projector projector, SurroundSound surroundSound, TheaterLights theaterLights)
    {
        _dvdPlayer = dvdPlayer;
        _projector = projector;
        _surroundSound = surroundSound;
        _theaterLights = theaterLights;
    }
    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _theaterLights.Dim(10);
        _projector.On();
        _projector.WideScreenMode();
        _surroundSound.On();
        _surroundSound.SetVolume(5);
        _dvdPlayer.On();
        _dvdPlayer.Play(movie);
    }
    public void EndMovie()
    {
        Console.WriteLine("Shutting movie theater down...");
        _theaterLights.On();
        _surroundSound.Off();
        _dvdPlayer.Off();
        _projector.Off();
    }
}

public static class HomeTheaterSystem
{
    public static void Main()
    {
        DVDPlayer dvdPlayer = new DVDPlayer();
        Projector projector = new Projector();
        SurroundSound surroundSound = new SurroundSound();
        TheaterLights theaterLights = new TheaterLights();
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, projector, surroundSound, theaterLights);
        homeTheater.WatchMovie("Inception");
        homeTheater.EndMovie();
    }
}
