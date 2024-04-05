using Stride.Engine;
using Stride.Graphics;
using System;

namespace FirstPersonShooter;
public class CustomGame : Game
{
	protected override void BeginRun()
	{
		base.BeginRun();


		WindowMinimumUpdateRate.MinimumElapsedTime = TimeSpan.FromMilliseconds(1000f / 100f); // set to screen refresh rate
		MinimizedMinimumUpdateRate.MinimumElapsedTime = TimeSpan.FromMilliseconds(1000f / 100f); // set to screen refresh rate

		Settings.Configurations.Get<RenderingSettings>().DefaultBackBufferHeight = 1080; // set to screen res
		Settings.Configurations.Get<RenderingSettings>().DefaultBackBufferWidth = 1920; // set to screen res
	}
}
