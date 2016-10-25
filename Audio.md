- Support format:  `AIFF`, `WAV`, `MP3` and `Ogg`

- `AudioSource` `Play` vs `PlayOneShot`

  ```C#
  public void Play(ulong delay = 0);

  public void PlayOneShot(AudioClip clip, float volumeScale = 1.0F);
  ```
  >我们先看看Play方法，该方法可以和其它方法配合使用，比如Pause（暂停）和Stop（停止），播放的是clip属性对应的Audio Clip对象，同一时刻只会有一个clip音乐进行播放。如果要同时使用Play方法播放两个音乐就需要再添加一个Audio Source对象了。

  >而PlayOneShot是指马上播放一个音乐且只播放一次，同时Pause和Stop对其无效，如果我们调用该方法播放多次音乐，则多个音乐会同时被播放出来。([Ref](http://www.cnblogs.com/hammerc/p/4784688.html))


 - 在IOS上，可以使用Apple硬件解码的功能来得到更好的效率。在Audio Importer中勾上"Hardware Decoding"即可。([Ref](http://www.cnblogs.com/sifenkesi/p/3503836.html))
