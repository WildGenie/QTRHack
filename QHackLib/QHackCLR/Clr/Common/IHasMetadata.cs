﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QHackCLR.Clr
{
	public interface IHasMetadata
	{
		int MDToken { get; }
	}
}
