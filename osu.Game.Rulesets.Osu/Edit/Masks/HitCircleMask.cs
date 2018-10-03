// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Graphics;
using osu.Game.Rulesets.Osu.Objects;
using osu.Game.Rulesets.Osu.Objects.Drawables.Pieces;
using OpenTK;

namespace osu.Game.Rulesets.Osu.Edit.Masks
{
    public class HitCircleMask : CompositeDrawable
    {
        public HitCircleMask(HitCircle hitCircle)
        {
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;

            Size = new Vector2((float)OsuHitObject.OBJECT_RADIUS * 2);
            Scale = new Vector2(hitCircle.Scale);

            CornerRadius = Size.X / 2;

            AddInternal(new RingPiece());
        }

        [BackgroundDependencyLoader]
        private void load(OsuColour colours)
        {
            Colour = colours.Yellow;
        }
    }
}
