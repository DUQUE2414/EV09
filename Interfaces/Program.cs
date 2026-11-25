System.Console.WriteLine();
System.Console.WriteLine("Interfaces");
System.Console.WriteLine();


MusicPlayer player = new MusicPlayer();
player.LoadTrack("Darte remix");
player.Play();
Console.WriteLine($"Pista actual: {player.GetCurrentTrack()}");
player.Pause();
player.Stop();
Console.WriteLine($"Pista tras detenerse: {player.GetCurrentTrack()}");

interface IMediaPlayer
{
    void Play();
    void Pause();
    void Stop();
    string GetCurrentTrack();
}

class MusicPlayer : IMediaPlayer
{
    private string current_track = "Sin pista";

    public void LoadTrack(string track_name)
    {
        current_track = track_name;
        Console.WriteLine($"Pista cargada: {current_track}");
    }

    public void Play()
    {
        Console.WriteLine($"Reproduciendo: {current_track}");
    }

    public void Pause()
    {
        Console.WriteLine("Pista en pausa");
    }

    public void Stop()
    {
        Console.WriteLine("Reproducción detenida");
        current_track = "Sin pista";
    }

    public string GetCurrentTrack()
    {
        return current_track;
    }
}





