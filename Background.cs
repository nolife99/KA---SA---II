using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Animations;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    //yes im compiling everything into one script
    public class Background : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    BackgroundFX();
            Flashes();
            ScalingSquares(12006, 22977, 10000, false);
            FlyingParticles(12006, 39435);
            Diamond(28463, 36606, 8);
            Diamond(36692, 36695, 12);
            Diamond(37377, 37977, 16);
            Spectrum(39435, 61377);
            ScalingSquares(39435, 61377, 5100, false);
            FlyingParticles(61377, 94292);
            Diamond(83320, 91463, 8);
            Diamond(91549, 91892, 12);
            Diamond(92235, 92834, 16);
            ScalingSquares(94292, 116235, 5100, false);
            Spectrum(94292, 116235);
            BeamStrike(105263, 116149);
            FlyingParticles(116235, 165606);
            BeatParticles(176577, 187549);
            ScalingSquares(138177, 149149, 10000, true);
            Diamond(154634, 162777, 8);
            Diamond(162863, 163463, 12);
            Diamond(163549, 164149, 16);
            PulsingSquare(165606, 187549);
            Spectrum(165606, 187549);
            ScalingSquares(165606, 187549, 5100, true);
            FlyingParticles(198520, 258863);
            ScalingSquares(220463, 242406, 10000, false);
            Diamond(247892, 256115, 8);
            Diamond(256120, 256720, 12);
            Diamond(256806, 257406, 16);
            Spectrum(258863, 302749);
            FlyingParticles(280806, 302749);
            ScalingSquares(258863, 302749, 5100, false);
            PulsingSquare(280806, 302749);
            ScalingSquares(280806, 302749, 5200, true);
            BeamStrike(279434, 302663);
            BeamStrike(305149, 306863);

            var times = new int[]{
                22977, 23320, 23663, 24349, 24692, 25035, 25720, 26406, 27092, 27435, 27777, 38063, 38406, 38749, 77835,
                78177, 78520, 79206, 79549, 79892, 80577, 81263, 81949, 82292, 82635, 92920, 93263, 93606, 149149, 149492,
                149835, 150520, 150863, 151206, 151892, 152577, 153263, 153606, 153949, 164235, 164577, 164920, 242406,
                242749, 243092, 243777, 244120, 244463, 245149, 245835, 246520, 246863, 247206, 257492, 257835, 258177, 
                280806, 297263, 297606, 297949, 298635, 298977, 299320, 300006, 300692, 301035, 302749, 306863
            };
            foreach (var time in times)
            {
                Rings(time);
            }
        }
        public void BackgroundFX()
        {
            int startRotation = -2;
            int endRotation = 2;
            var d = GetLayer("").CreateSprite("bg.jpg");
            d.Fade(0, 0);

            var bitmap = GetMapsetBitmap("sb/bg.jpg");
            var bg = GetLayer("").CreateSprite("sb/bg.jpg");
            bg.Scale(1034, 870.0f / bitmap.Width);
            bg.Fade(1034, 1);

            var velocity = 15000;
            var rotation = MathHelper.DegreesToRadians(startRotation);
            var rotateEnd = MathHelper.DegreesToRadians(endRotation);

            bg.StartLoopGroup(12006, (61377 - 12006) / velocity);
            bg.Rotate(OsbEasing.InOutSine, 0, velocity / 2, rotation, rotateEnd);
            bg.Rotate(OsbEasing.InOutSine, velocity / 2, velocity, rotateEnd, rotation);
            bg.EndGroup();

            bg.StartLoopGroup(83320, (121720 - 83320) / velocity);
            bg.Rotate(OsbEasing.InOutSine, 0, velocity / 2, rotation, rotateEnd);
            bg.Rotate(OsbEasing.InOutSine, velocity / 2, velocity, rotateEnd, rotation);
            bg.EndGroup();

            bg.StartLoopGroup(138177, (190292 - 138177) / velocity);
            bg.Rotate(OsbEasing.InOutSine, 0, velocity / 2, rotation, rotateEnd);
            bg.Rotate(OsbEasing.InOutSine, velocity / 2, velocity, rotateEnd, rotation);
            bg.EndGroup();

            bg.StartLoopGroup(220463, (302749 - 220463) / velocity);
            bg.Rotate(OsbEasing.InOutSine, 0, velocity / 2, rotation, rotateEnd);
            bg.Rotate(OsbEasing.InOutSine, velocity / 2, velocity, rotateEnd, rotation);
            bg.EndGroup();

            bg.Fade(306863, 312349, 1, 0);

            var Bitmap = GetMapsetBitmap("sb/bgblur.jpg");
            var blur = GetLayer("blur").CreateSprite("sb/bgblur.jpg");
            blur.Scale(21606, 22977, 870.0f / Bitmap.Width, 870.0f / Bitmap.Width + 0.02);
            blur.Fade(21606, 22292, 0, 0.6);
            blur.Fade(22292, 22977, 0.6, 0);
            blur.Fade(38063, 39092, 0, 0.6);
            blur.Fade(39435, 0);
            blur.Fade(92920, 93606, 0, 0.6);
            blur.Fade(94292, 0);
            blur.Fade(103892, 104577, 0, 0.75);
            blur.Fade(105263, 0);
            blur.Fade(147777, 148463, 0, 0.6);
            blur.Fade(148806, 149149, 0.6, 0);
            blur.Fade(164235, 164920, 0, 0.6);
            blur.Fade(165606, 0);
            blur.Fade(241035, 241720, 0, 0.6);
            blur.Fade(242063, 242406, 0.6, 0);
            blur.Fade(257492, 258177, 0, 0.6);
            blur.Fade(258863, 0);
            blur.Fade(279434, 280120, 0, 0.75);
            blur.Fade(280806, 0);

            bg.Fade(38063, 38749, 0.7, 0);
            bg.Fade(39092, 39435, 0, 1);
            bg.Fade(92920, 93606, 0.7, 0);
            bg.Fade(93949, 94292, 0, 1);
            bg.Fade(164235, 164920, 0.7, 0);
            bg.Fade(165263, 165606, 0, 1);
            bg.Fade(187549, 193035, 1, 0);
            bg.Fade(197149, 198520, 0, 1);
            bg.Fade(217720, 219092, 1, 0.7);
            bg.Fade(219777, 220463, 0.7, 1);
            bg.Fade(258863, 1);

            bg.Fade(28463, 0.7);
            bg.Fade(83320, 0.7);
            bg.Fade(154634, 0.7);
            bg.Fade(247892, 0.7);

            var flashBitmap = GetMapsetBitmap("sb/pillar.png");
            var beatFlash = GetLayer("hellish light").CreateSprite("sb/pillar.png", OsbOrigin.BottomCentre, new Vector2(-127, 400));
            beatFlash.Scale(39435, 900.0f / flashBitmap.Height);
            beatFlash.Rotate(39435, MathHelper.DegreesToRadians(90));

            //workaround to prevent offset
            var flashStep = Beatmap.GetTimingPointAt(39435).BeatDuration;
            for (double i = 39435; i < 61292; i += flashStep)
            {
                beatFlash.Fade(i, i + flashStep, 0.8, 0);
            }
            flashStep = Beatmap.GetTimingPointAt(94292).BeatDuration * 2;
            for (double i = 94292; i < 116235; i += flashStep)
            {
                beatFlash.Fade(i, i + flashStep, 0.8, 0);
            }
            flashStep = Beatmap.GetTimingPointAt(165606).BeatDuration;
            for (double i = 165606; i < 175206; i += flashStep)
            {
                beatFlash.Fade(i, i + flashStep, 0.8, 0);
            }
            flashStep = Beatmap.GetTimingPointAt(176577).BeatDuration * 2;
            for (double i = 176577; i < 186349; i += flashStep)
            {
                beatFlash.Fade(i, i + flashStep, 0.8, 0);
            }
            flashStep = Beatmap.GetTimingPointAt(258863).BeatDuration;
            for (double i = 258863; i < 279434; i += flashStep)
            {
                beatFlash.Fade(i, i + flashStep, 0.8, 0);
            }
            flashStep = Beatmap.GetTimingPointAt(280806).BeatDuration;
            for (double i = 280806; i < 301377; i += flashStep)
            {
                beatFlash.Fade(i, i + flashStep, 0.8, 0);
            }

            var timeStep = Beatmap.GetTimingPointAt(280806).BeatDuration * 2;
            var bgFlash = GetLayer("s").CreateSprite("sb/bg.jpg");
            bgFlash.Additive(280806);
            for (double i = 280806; i < 290406; i += timeStep)
            {
                bgFlash.Fade(i, i + timeStep, 0.5, 0);
                bgFlash.Scale(i, i + timeStep, 870.0f / bitmap.Width, 870.0f / bitmap.Width + 0.01);
                bgFlash.Rotate(i, i + timeStep, bg.RotationAt(i), bg.RotationAt(i + timeStep));
            }
            for (double i = 291777; i < 301377; i += timeStep)
            {
                bgFlash.Fade(i, i + timeStep, 0.5, 0);
                bgFlash.Scale(i, i + timeStep, 870.0f / bitmap.Width, 870.0f / bitmap.Width + 0.01);
                if (i < 295549)
                    bgFlash.Rotate(i, i + timeStep, bg.RotationAt(i), bg.RotationAt(i + timeStep));
            }
        }
        public void Flashes()
        {
            var pix = GetLayer("Flash").CreateSprite("sb/pixel.png", OsbOrigin.Centre, new Vector2(320, 240));
            pix.ScaleVec(1034, 854, 480);
            pix.Fade(1034, 6520, 0.8, 0);
            pix.Fade(12006, 14749, 0.8, 0);

            //workaround to prevent offset
            var timeStep = Beatmap.GetTimingPointAt(28463).BeatDuration;
            for (double i = 28463; i < 33777; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(33949).BeatDuration / 2;
            for (double i = 33949; i < 35235; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(35320).BeatDuration / 4;
            for (double i = 35320; i < 37320; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.5, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(37377).BeatDuration / 6;
            for (double i = 37377; i < 37692; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(37720).BeatDuration / 8;
            for (double i = 37720; i < 38063; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.7, 0);
            }
            pix.Fade(39435, 40806, 0.8, 0);
            pix.Fade(51777, 53149, 0.8, 0);
            pix.Fade(61377, 66863, 0.8, 0);
            pix.Fade(72349, 73720, 0.8, 0);

            timeStep = Beatmap.GetTimingPointAt(83320).BeatDuration;
            for (double i = 83320; i < 88720; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(88806).BeatDuration / 2;
            for (double i = 88806; i < 90092; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(90177).BeatDuration / 4;
            for (double i = 90177; i < 91540; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.5, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(91549).BeatDuration / 6;
            for (double i = 91549; i < 92230; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(92235).BeatDuration / 8;
            for (double i = 92235; i < 92920; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.7, 0);
            }
            pix.Fade(94292, 95663, 0.8, 0);
            pix.Fade(105263, 106635, 0.8, 0);
            pix.Fade(116235, 121720, 0.8, 0);
            pix.Fade(138177, 140920, 0.8, 0);

            timeStep = Beatmap.GetTimingPointAt(154634).BeatDuration;
            for (double i = 154634; i < 160035; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(160120).BeatDuration / 2;
            for (double i = 160120; i < 161406; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(161492).BeatDuration / 4;
            for (double i = 161492; i < 162860; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.5, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(162863).BeatDuration / 6;
            for (double i = 162863; i < 163540; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(163549).BeatDuration / 8;
            for (double i = 163549; i < 164235; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.7, 0);
            }
            pix.Fade(176577, 177949, 0.8, 0);
            pix.Fade(165606, 166977, 0.8, 0);
            pix.Fade(187549, 193035, 0.8, 0);
            
            timeStep = Beatmap.GetTimingPointAt(217720).BeatDuration / 6;
            for (double i = 217720; i < 219092; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.2, 0);
            }
            pix.Fade(220463, 223206, 0.8, 0);

            timeStep = Beatmap.GetTimingPointAt(231434).BeatDuration;
            for (double i = 231434; i < 241035; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.3, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(247892).BeatDuration;
            for (double i = 247892; i < 253292; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(253377).BeatDuration / 2;
            for (double i = 253377; i < 254663; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(254749).BeatDuration / 4;
            for (double i = 254749; i < 256117; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.5, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(256120).BeatDuration / 6;
            for (double i = 256120; i < 256801; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.6, 0);
            }
            timeStep = Beatmap.GetTimingPointAt(256806).BeatDuration / 8;
            for (double i = 256806; i < 257492; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.7, 0);
            }
            pix.Fade(258863, 261606, 0.8, 0);
            pix.Fade(269834, 272577, 0.8, 0);
            pix.Fade(279434, 280806, 0, 0.4);
            pix.Fade(280806, 283549, 0.8, 0);
            pix.Fade(291777, 294520, 0.8, 0);
            pix.Fade(302749, 305492, 0.8, 0);

            timeStep = Beatmap.GetTimingPointAt(297263).BeatDuration;
            for (double i = 297263; i < 298035; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.5, 0);
            }
            for (double i = 298635; i < 299406; i += timeStep)
            {
                pix.Fade(i, i + timeStep - 1, 0.5, 0);
            }
            pix.Fade(300006, 300692, 0.5, 0);
            pix.Fade(300692, 302749, 0.5, 0);
        }
        public void Rings(int time)
        {
            var duration = Beatmap.GetTimingPointAt(time).BeatDuration * 5;
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if (hitobject.StartTime == time)
                {
                    var ring = GetLayer("pass").CreateSprite("sb/ring.png", OsbOrigin.Centre, hitobject.Position);
                    ring.Scale(OsbEasing.Out, hitobject.StartTime, hitobject.StartTime + duration, 0.3, 1.2);
                    ring.Fade(OsbEasing.Out, hitobject.StartTime, hitobject.StartTime + duration, 1, 0);
                }
            }
        }
        public void Diamond(int startTime, int endTime, int BeatDivisor)
        {
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if (hitobject.StartTime > startTime - 5 && hitobject.StartTime < endTime + 5)
                {
                    var vectorSquare = GetLayer("pass").CreateSprite("sb/pixel.png", OsbOrigin.Centre, hitobject.Position);
                    vectorSquare.Scale(OsbEasing.OutElastic, hitobject.StartTime, hitobject.StartTime + 300, 110, 80);
                    vectorSquare.Rotate(hitobject.StartTime, MathHelper.DegreesToRadians(45));
                    vectorSquare.Fade(hitobject.StartTime, 0.8);
                    vectorSquare.Fade(OsbEasing.InQuad, hitobject.EndTime, hitobject.EndTime + 300, 0.8, 0);

                    if (hitobject is OsuSlider)
                    {
                        var timeStep = Beatmap.GetTimingPointAt((int)hitobject.StartTime).BeatDuration / BeatDivisor;
                        var StartTime = hitobject.StartTime;
                        while (true)
                        {
                            var EndTime = StartTime + timeStep;

                            var complete = hitobject.EndTime - EndTime < 5;
                            if (complete) EndTime = hitobject.EndTime;

                            var startPosition = vectorSquare.PositionAt(StartTime);
                            vectorSquare.Move(StartTime, EndTime, startPosition, hitobject.PositionAtTime(EndTime));

                            if (complete) break;
                            StartTime += timeStep;
                        }
                    }
                }
            }
        }
        private void ScalingSquares(int StartTime, int EndTime, int TravelTime, bool circle)
        {
            string path = "sb/pixel.png";
            var TimeBetweenSprites = 50;

            double SpriteScaleMin = 2;
            double SpriteScaleMax = 10;
            var SpriteFadeMin = 0.1;
            var SpriteFadeMax = 0.8;

            if (circle)
            {
                path = "sb/circle.png";
                SpriteScaleMin = 0.004;
                SpriteScaleMax = 0.017;
            }

            var MinTravelTime = Random(TravelTime / 2, TravelTime - 1000);
            var MaxTravelTime = TravelTime;
            var FadeTimeIn = 250;
            var FadeTimeOut = 250;

            var RandomScale = true;
            var RandomFade = true;
            var RandomTravelTime = true;

            int posX, posY;
            if (TimeBetweenSprites != 0)
            {
                for (int i = StartTime; i <= EndTime; i += TimeBetweenSprites)
                {
                    posX = Random(-107, 747);
                    posY = Random(480, 490);

                    var endY = Random(-10, 100);
                    var s = GetLayer("").CreateSprite(path, OsbOrigin.Centre, new Vector2(posX, 0));
                    var RealScaling = Random(SpriteScaleMin, SpriteScaleMax);
                    var RealFadeAmount = Math.Round(Random(SpriteFadeMin, SpriteFadeMax), 3);
                    var RealTravelTime = Random(MinTravelTime, MaxTravelTime);

                    var Scale = RealScaling;
                    s.ScaleVec(i, i + RealTravelTime / 2, Scale, Scale, Scale, -Scale);
                    s.ScaleVec(i + RealTravelTime / 2, i + RealTravelTime, Scale, -Scale, Scale, Scale);
                    s.Rotate(i, i + RealTravelTime / 2, MathHelper.DegreesToRadians(-90), MathHelper.DegreesToRadians(90));
                    s.Rotate(i + RealTravelTime / 2, i + RealTravelTime, MathHelper.DegreesToRadians(90), MathHelper.DegreesToRadians(180));
                    s.MoveY(i, i + RealTravelTime, posY, endY);

                    if (i < EndTime - (FadeTimeIn + FadeTimeOut))
                    {
                        s.Fade(i, i + FadeTimeIn, 0, RealFadeAmount);

                        if (i < EndTime - RealTravelTime)
                        {
                            s.Fade(i + RealTravelTime - FadeTimeOut, i + RealTravelTime, RealFadeAmount, 0);
                        }

                        else
                        {
                            s.Fade(EndTime - FadeTimeOut, EndTime, RealFadeAmount, 0);
                        }
                    }
                    else
                    {
                        s.Fade(i, 0);
                    }
                }
            }
        }
        public void Spectrum(int StartTime, int EndTime)
        {
            var MinimalHeight = 0.5f;
            var ScaleY = 70;
            float LogScale = 6;
            Vector2 Position = new Vector2(326, 240);

            int BarCount = 75;
            var bitmap = GetMapsetBitmap("sb/pixel.png");
            var Width = 857.0f / bitmap.Width;

            var heightKeyframes = new KeyframedValue<float>[BarCount];
            for (var i = 0; i < BarCount; i++)
                heightKeyframes[i] = new KeyframedValue<float>(null);

            double timeStep = Beatmap.GetTimingPointAt(StartTime).BeatDuration / 8;
            double offset = timeStep * 0.2;
            for (var t = (double)StartTime; t < EndTime; t += timeStep)
            {
                var fft = GetFft(t + offset, BarCount, null, OsbEasing.InExpo);
                for (var i = 0; i < BarCount; i++)
                {
                    var height = (float)Math.Log10(1 + fft[i] * LogScale) * ScaleY / bitmap.Height;
                    if (height < MinimalHeight) height = MinimalHeight;

                    heightKeyframes[i].Add(t, height);
                }
            }
            var barWidth = Width / BarCount;
            var posX = Position.X - (Width / 2);

            for (var i = 0; i < BarCount; i++)
            {
                var keyframes = heightKeyframes[i];
                keyframes.Simplify1dKeyframes(1, h => h);

                var topBar = GetLayer("Spectrum").CreateSprite("sb/pixel.png", OsbOrigin.Centre, new Vector2(posX + i * barWidth, 0));
                var bottomBar = GetLayer("Spectrum").CreateSprite("sb/pixel.png", OsbOrigin.Centre, new Vector2(posX + i * barWidth, 0));

                var Color = Color4.MediumSlateBlue;
                topBar.Scale(StartTime, barWidth / 2);
                bottomBar.Scale(StartTime, barWidth / 2);
                bottomBar.Color(StartTime, Color);
                topBar.Color(StartTime, Color);
                bottomBar.Additive(StartTime, EndTime);
                topBar.Additive(StartTime, EndTime);
                bottomBar.Fade(StartTime + i * 30, StartTime + i * 30 + 1500, 0, 1);
                bottomBar.Fade(EndTime - 1000, EndTime, 1, 0);
                topBar.Fade(StartTime + i * 30, StartTime + i * 30 + 1500, 0, 1);
                topBar.Fade(EndTime - 1000, EndTime, 1, 0);

                keyframes.ForEachPair(
                    (start, end) =>
                    {
                        topBar.MoveY(start.Time, end.Time, 
                        Position.Y - start.Value / 2 * LogScale, Position.Y - end.Value / 2 * LogScale);

                        bottomBar.MoveY(start.Time, end.Time, 
                        Position.Y + start.Value / 2 * LogScale, Position.Y + end.Value / 2 * LogScale);
                    },
                    MinimalHeight,
                    s => (float)Math.Round(s, 0)
                );
            }
        }
        public void FlyingParticles(int startTime, int endTime)
        {
            for (int i = 0; i < 80; i++)
            {
                var posX = Random(-107, 647);
                var endX = 747;
                var posY = Random(0, 480);
                var duration = Random(10000, 40000);
                var firstDuration = Random(1000, 10000);

                var pix = GetLayer("particle").CreateSprite("sb/pixel.png", OsbOrigin.Centre, new Vector2(0, posY));
                pix.Fade(startTime + firstDuration, startTime + firstDuration + i * 20, 0, 1);
                pix.MoveX(startTime + firstDuration, startTime + firstDuration + i * 100, posX, endX);
                pix.Scale(startTime + i * 50, 0.85);

                var particleStartTime = startTime + firstDuration + i * 100;
                while (particleStartTime < endTime)
                {
                    pix.MoveX(particleStartTime, particleStartTime + duration, -107, endX);
                    particleStartTime += duration;
                }
                pix.Fade(endTime - 500, endTime, 1, 0);
            }
        }
        public void BeatParticles(int startTime, int endTime)
        {
            for (int i = 0; i < 20; i++)
            {
                var timeStep = Beatmap.GetTimingPointAt(startTime).BeatDuration;
                var posX = Random(-107, 747);
                var RandomScale = Random(10, 50);
                var realStart = startTime + timeStep * i;

                var square = GetLayer("particle").CreateSprite("sb/pixel.png", OsbOrigin.Centre, new Vector2(posX, 0));
                square.Color(realStart, Color4.White);
                square.Fade(realStart, realStart + 150, 0, 0.7);
                square.Scale(realStart, RandomScale);

                var posY = 500;
                var rotation = 0f;
                for (double s = realStart; s < endTime - 1; s += timeStep)
                {
                    var endY = posY - Random(27, 77);
                    square.MoveY(OsbEasing.OutQuad, s, s + timeStep, posY, endY);

                    if (endY < -20)
                    {
                        posY = 510;
                    }
                    else
                    {
                        posY = endY;
                    }
                }
                for (double r = startTime; r < endTime - 1; r += timeStep)
                {
                    var nRotation = rotation + MathHelper.DegreesToRadians(45);
                    square.Rotate(OsbEasing.OutExpo, r, r + timeStep, rotation, nRotation);
                    rotation = nRotation;
                }
                square.Fade(endTime - 250, endTime, 0.7, 0);
            }
        }
        private void BeamStrike(int startTime, int endTime)
        {
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if (hitobject.StartTime >= startTime && hitobject.StartTime <= endTime)
                {
                    int scaleY = 1000;
                    var sprite = GetLayer("pass").CreateSprite("sb/pixel.png", OsbOrigin.Centre, hitobject.Position);
                    sprite.Rotate(hitobject.StartTime, Random(-Math.PI / 12, Math.PI / 12));
                    sprite.ScaleVec(OsbEasing.OutExpo, hitobject.StartTime, hitobject.StartTime + 1000, 1.5, scaleY, 0, scaleY);
                    sprite.Additive(hitobject.StartTime);
                    sprite.Fade(hitobject.StartTime, 0.8);
                }
            }
        }
        public void PulsingSquare(int startTime, int endTime)
        {
            var easing = OsbEasing.OutQuad;
            var timeStep = Beatmap.GetTimingPointAt(startTime).BeatDuration;
            var pix = GetLayer("BeatScale").CreateSprite("sb/pixel.png");
            for (double i = startTime; i < endTime - 1; i += timeStep)
            {
                pix.Scale(easing, i, i + timeStep, 120, 80);
                pix.Fade(easing, i, i + timeStep, 0.5, 1);
            }
            pix.Rotate(startTime, MathHelper.DegreesToRadians(45));
            pix.Scale(easing, endTime, endTime + timeStep, 140, 0);

            double angle = 0;
            var scaleStart = 85;
            var scaleEnd = 150;
            var pos = new Vector2(320, 240);
            for (int i = 0; i < 4; i++)
            {
                var startPos = new Vector2(
                    (float)(pos.X + Math.Cos(angle) * scaleStart),
                    (float)(pos.Y + Math.Sin(angle) * scaleStart));

                var endPos = new Vector2(
                    (float)(pos.X + Math.Cos(angle) * scaleEnd),
                    (float)(pos.Y + Math.Sin(angle) * scaleEnd));

                double startScale = Math.Sqrt(scaleStart * scaleStart + scaleStart * scaleStart);
                double endScale = Math.Sqrt(scaleEnd * scaleEnd + scaleEnd * scaleEnd);

                var pixOut = GetLayer("BeatScale").CreateSprite("sb/pixel.png", OsbOrigin.BottomCentre);
                pixOut.Rotate(startTime, angle - Math.PI / 4);
                for (double s = startTime; s < endTime - 1; s += timeStep)
                {
                    pixOut.ScaleVec(easing, s, s + timeStep, 1.23, startScale + 0.5, 0.6, endScale);
                    pixOut.Move(easing, s, s + timeStep, startPos, endPos);
                    pixOut.Fade(OsbEasing.In, s, s + timeStep, 0.8, 0);
                }
                angle += Math.PI / 2;
            }
        }
    }
}
