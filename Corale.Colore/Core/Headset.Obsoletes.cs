﻿// ---------------------------------------------------------------------------------------
// <copyright file="Headset.Obsoletes.cs" company="Corale">
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
    using System;
    using Corale.Colore.Razer.Headset.Effects;

    /// <summary>
    /// Class for interacting with Chroma Headsets.
    /// </summary>
    public sealed partial class Headset : Device, IHeadset
    {
        /// <summary>
        /// Sets the color of all components on this device.
        /// </summary>
        /// <param name="color">Color to set.</param>
        [Obsolete("Set is deprecated, please use SetAll(Effect).", false)]
        public override void Set(Color color)
        {
            SetAll(color);
        }

        /// <summary>
        /// Sets an effect on the headset that doesn't
        /// take any parameters, currently only valid
        /// for the <see cref="Effect.SpectrumCycling" /> effect.
        /// </summary>
        /// <param name="effect">The type of effect to set.</param>
        [Obsolete("Set is deprecated, please use SetEffect(Effect).", false)]
        public void Set(Effect effect)
        {
            SetEffect(effect);
        }

        /// <summary>
        /// Sets a new static effect on the headset.
        /// </summary>
        /// <param name="effect">
        /// An instance of the <see cref="Static" /> struct
        /// describing the effect.
        /// </param>
        [Obsolete("Set is deprecated, please use SetStatic(Static).", false)]
        public void Set(Static effect)
        {
            SetStatic(effect);
        }

        /// <summary>
        /// Sets a new breathing effect on the headset.
        /// </summary>
        /// <param name="effect">
        /// An instance of the <see cref="Breathing" /> struct
        /// describing the effect.
        /// </param>
        [Obsolete("Set is deprecated, please use SetBreathing(Breathing).", false)]
        public void Set(Breathing effect)
        {
            SetBreathing(effect);
        }
    }
}
