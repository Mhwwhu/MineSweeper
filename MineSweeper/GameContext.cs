using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MineSweeper
{
	public class GameContext
	{
		public Block[] Blocks {  get; set; }
		public IConfiguration Configure { get; set; }
		public IServiceProvider ServiceProvider { get; set; }
	}
}
