using Stride.Engine;
using Stride.Graphics;
using System;

namespace FirstPersonShooter;
public class CustomGame : Game
{
	protected override void BeginRun()
	{
		base.BeginRun();


		WindowMinimumUpdateRate.MinimumElapsedTime = TimeSpan.Zero; // set to screen refresh rate
		GraphicsDevice.Presenter.PresentInterval = Stride.Graphics.PresentInterval.Immediate;

		Settings.Configurations.Get<RenderingSettings>().DefaultBackBufferHeight = 1080; // set to screen res
		Settings.Configurations.Get<RenderingSettings>().DefaultBackBufferWidth = 1920; // set to screen res
	}
}
