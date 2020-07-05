using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
	public class BeeperManager
	{
		public bool IsPlaying;
		public bool IsLooping;
		public WaveOut Sound;
		public IEnumerable<Beeper> Beepers;

		public void Play(IEnumerable<Beeper> beepers, bool looping = false)
		{
			Beepers = beepers;

			MixingWaveProvider32 mixer = new MixingWaveProvider32();
			foreach (Beeper beeper in beepers)
			{
				beeper.Stream.Seek(0, SeekOrigin.Begin);
				mixer.AddInputStream(new WaveChannel32(new WaveFileReader(beeper.Stream)));
			}

			Sound = new WaveOut(WaveCallbackInfo.FunctionCallback());
			Sound.Init(mixer);
			
			IsLooping = looping;
			Sound.PlaybackStopped += OnSoundPlayBackStopped;
			Sound.Play();
			IsPlaying = true;
		}

		public void Stop()
		{
			IsPlaying = false;

			if (Sound == null)
				return;

			Sound.Stop();
			Sound.PlaybackStopped -= OnSoundPlayBackStopped;
			Sound.Dispose();
			Sound = null;

			IsLooping = false;
		}

		private void OnSoundPlayBackStopped(object sender, StoppedEventArgs e)
		{
			bool wasLooping = IsLooping;

			Stop();

			if (wasLooping)
				Play(Beepers, true);
		}
	}
}
