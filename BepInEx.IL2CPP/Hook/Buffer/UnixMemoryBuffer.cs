﻿using System;

namespace BepInEx.IL2CPP
{
	public class UnixMemoryBuffer : MemoryBuffer
	{
		public override IntPtr Allocate(IntPtr func)
		{
			throw new NotImplementedException();
		}

		public override void Free(IntPtr buffer)
		{
			throw new NotImplementedException();
		}
	}
}