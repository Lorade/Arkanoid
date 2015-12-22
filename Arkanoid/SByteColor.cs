using System;
using SFML.System;
using SFML.Graphics;

namespace Arkanoid
{
   struct ByteColor
   {
        //Deklaration

        private byte mRed;
        private byte mGreen;
        private byte mBlue;
        private byte mAlpha;

        //Allgemeiner Konstruktor

        public ByteColor(byte red, byte green, byte blue)
        {
            this.mRed = red;
            this.mGreen = green;
            this.mBlue = blue;
            this.mAlpha = byte.MaxValue;
        }

        //Konstruktor mit Alpha

        public ByteColor(byte red, byte green, byte blue, byte alpha)
        {
            this.mRed = red;
            this.mGreen = green;
            this.mBlue = blue;
            this.mAlpha = alpha;
        }

        //ToColor Convert Methode

        public Color ToColor()
        {
            return new Color(mRed, mGreen, mBlue, mAlpha);
        }

        //Override ToString() von Object für bessere Ausgabe

        public override string ToString()
        {
            return "Red = " + mRed + " Green = " + mGreen + " Blue = " + mBlue + " Alpha = " + mAlpha;
        }

        //Eigenschaften [GET / SET]

        public byte Red
        {
            get
            {
                return this.mRed;
            }

            set
            {
                this.mRed = value;
            }
        }

        public byte Green
        {
            get
            {
                return this.mGreen;
            }

            set
            {
                this.mGreen = value;
            }
        }

        public byte Blue
        {
            get
            {
                return this.mBlue;
            }

            set
            {
                this.mBlue = value;
            }
        }

        public byte Alpha
        {
            get
            {
                return this.mAlpha;
            }

            set
            {
                this.mAlpha = value;
            }
        }
   }
}
