namespace Facade
{
    public class PlayerFacade
    {
        private DVD _dvd;
        private IPlayer _dvdPlayer;

        public PlayerFacade(DVD dvd, IPlayer dvdPlayer)
        {
            _dvd = dvd;
            _dvdPlayer = dvdPlayer;
        }

        public void WatchVideo()
        {
            _dvdPlayer.On();
            _dvdPlayer.Insert(_dvd);
            _dvdPlayer.Play();
        }

        public void Pause()
        {
            _dvdPlayer.Pause();
        }

        public void Resume()
        {
            _dvdPlayer.Resume();
        }
    }
}
