﻿using System;
using System.Collections.Generic;

public class KuwoSearchData
{
	// http://search.kuwo.cn/r.s?songname=%E6%90%81%E6%B5%85&ft=music&rformat=json&encoding=utf8&rn=8&callback=song&vipver=MUSIC_8.0.3.1
	public KuwoSearchData()
	{

	}

	public List<AbslistData> abslist { get; set; }

	public class AbslistData
    {
		public string SONGNAME { get; set; }

		public string ALBUM { get; set; }

		public string MUSICRID { get; set; }

	}
}
