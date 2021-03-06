﻿// ---------------------------------------------------------------------------------------
// <copyright file="Mousepad.cs" company="Corale">
//     Copyright © 2015 by Adam Hellberg and Brandon Scott.
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy of
//     this software and associated documentation files (the "Software"), to deal in
//     the Software without restriction, including without limitation the rights to
//     use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
//     of the Software, and to permit persons to whom the Software is furnished to do
//     so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//     WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
//     CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//     Disclaimer: Corale and/or Colore is in no way affiliated with Razer and/or any
//     of its employees and/or licensors. Corale, Adam Hellberg, and/or Brandon Scott
//     do not take responsibility for any harm caused, direct or indirect, to any
//     Razer peripherals via the use of Colore.
//
//     "Razer" is a trademark of Razer USA Ltd.
// </copyright>
// ---------------------------------------------------------------------------------------

namespace Corale.Colore.Core
{
    using Corale.Colore.Razer.Mousepad.Effects;

    using log4net;

    /// <summary>
    /// Class for interacting with a Chroma mouse pad.
    /// </summary>
    public sealed partial class Mousepad : Device, IMousepad
    {
        /// <summary>
        /// Logger instance for this class.
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(Mousepad));

        /// <summary>
        /// Singleton instance.
        /// </summary>
        private static IMousepad _instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="Mousepad" /> class from being created.
        /// </summary>
        private Mousepad()
        {
            Log.Debug("Mousepad is initializing.");
            Chroma.Initialize();
        }

        /// <summary>
        /// Gets the application-wide instance of the <see cref="IMousepad" /> interface.
        /// </summary>
        public static IMousepad Instance
        {
            get
            {
                return _instance ?? (_instance = new Mousepad());
            }
        }

        /// <summary>
        /// Sets the color of all components on this device.
        /// </summary>
        /// <param name="color">Color to set.</param>
        public override void SetAll(Color color)
        {
            SetGuid(NativeWrapper.CreateMousepadEffect(new Static(color)));
        }

        /// <summary>
        /// Sets an effect without any parameters.
        /// Currently, this only works for the <see cref="Effect.None" /> effect.
        /// </summary>
        /// <param name="effect">Effect options.</param>
        public void SetEffect(Effect effect)
        {
            SetGuid(NativeWrapper.CreateMousepadEffect(effect));
        }

        /// <summary>
        /// Sets a breathing effect on the mouse pad.
        /// </summary>
        /// <param name="effect">An instance of the <see cref="Breathing" /> struct.</param>
        public void SetBreathing(Breathing effect)
        {
            SetGuid(NativeWrapper.CreateMousepadEffect(effect));
        }

        /// <summary>
        /// Sets a static color effect on the mouse pad.
        /// </summary>
        /// <param name="effect">An instance of the <see cref="Static" /> struct.</param>
        public void SetStatic(Static effect)
        {
            SetGuid(NativeWrapper.CreateMousepadEffect(effect));
        }

        /// <summary>
        /// Sets a wave effect on the mouse pad.
        /// </summary>
        /// <param name="effect">An instance of the <see cref="Wave" /> struct.</param>
        public void SetWave(Wave effect)
        {
            SetGuid(NativeWrapper.CreateMousepadEffect(effect));
        }

        /// <summary>
        /// Sets a custom effect on the mouse pad.
        /// </summary>
        /// <param name="effect">An instance of the <see cref="Custom" /> struct.</param>
        public void SetCustom(Custom effect)
        {
            SetGuid(NativeWrapper.CreateMousepadEffect(effect));
        }
    }
}
