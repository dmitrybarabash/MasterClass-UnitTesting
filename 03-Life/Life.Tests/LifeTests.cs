using Life;
using NUnit.Framework;

namespace Life.Tests
{
    public class LifeTests
    {
        [Test]
        public void IsToLive_1_ToDie()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] = false; field.Cells[0, 2] = false;
            field.Cells[1, 0] = false; field.Cells[1, 1] =  true; field.Cells[1, 2] = false;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;

            bool result = field.IsToLive(1, 1);

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsToLive_2_ToDie()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] = false; field.Cells[0, 2] = false;
            field.Cells[1, 0] = false; field.Cells[1, 1] =  true; field.Cells[1, 2] =  true;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;

            bool result = field.IsToLive(1, 1);

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsToLive_3_ToLive()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] = false; field.Cells[0, 2] = false;
            field.Cells[1, 0] =  true; field.Cells[1, 1] =  true; field.Cells[1, 2] =  true;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;

            bool result = field.IsToLive(1, 1);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsToLive_3_ToBorn()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] =  true; field.Cells[0, 2] = false;
            field.Cells[1, 0] =  true; field.Cells[1, 1] = false; field.Cells[1, 2] =  true;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;

            bool result = field.IsToLive(1, 1);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsToLive_4_ToLive()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] =  true; field.Cells[0, 2] = false;
            field.Cells[1, 0] =  true; field.Cells[1, 1] =  true; field.Cells[1, 2] =  true;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;

            bool result = field.IsToLive(1, 1);

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsToLive_5_ToDie()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] = true; field.Cells[0, 2] = false;
            field.Cells[1, 0] =  true; field.Cells[1, 1] = true; field.Cells[1, 2] =  true;
            field.Cells[2, 0] = false; field.Cells[2, 1] = true; field.Cells[2, 2] = false;

            bool result = field.IsToLive(1, 1);

            Assert.That(result, Is.False);
        }


        [Test]
        public void GetNeighbourCount_x1y1_1()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] = false; field.Cells[0, 2] = false;
            field.Cells[1, 0] =  true; field.Cells[1, 1] =  true; field.Cells[1, 2] = false;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;
            var expected = 1;

            var actual = field.GetNeighbourCount(1, 1);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetNeighbourCount_x1y1_2()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] =  true; field.Cells[0, 2] = false;
            field.Cells[1, 0] =  true; field.Cells[1, 1] =  true; field.Cells[1, 2] = false;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;
            var expected = 2;

            var actual = field.GetNeighbourCount(1, 1);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetNeighbourCount_x1y1_3()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] =  true; field.Cells[0, 2] = false;
            field.Cells[1, 0] =  true; field.Cells[1, 1] =  true; field.Cells[1, 2] = false;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] =  true;
            var expected = 3;

            var actual = field.GetNeighbourCount(1, 1);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetNeighbourCount_x1y0_4()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = true; field.Cells[0, 1] = false; field.Cells[0, 2] = false;
            field.Cells[1, 0] = true; field.Cells[1, 1] =  true; field.Cells[1, 2] =  true;
            field.Cells[2, 0] = true; field.Cells[2, 1] = false; field.Cells[2, 2] = false;
            var expected = 4;

            var actual = field.GetNeighbourCount(1, 0);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void DieOrLive_WillBorn()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] =  true; field.Cells[0, 2] = false;
            field.Cells[1, 0] =  true; field.Cells[1, 1] = false; field.Cells[1, 2] =  true;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;
            var expected = true;

            field.DieOrLive(1, 1);
            var actual = field.Cells[1, 1];

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void MakeGeneration_NextGeneration()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] =  true; field.Cells[0, 2] = false;
            field.Cells[1, 0] =  true; field.Cells[1, 1] = false; field.Cells[1, 2] =  true;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;

            field.NextGeneration();

            Assert.That(true, Is.EqualTo(field.Cells[0, 0]));
            Assert.That(true, Is.EqualTo(field.Cells[0, 1]));
            Assert.That(true, Is.EqualTo(field.Cells[0, 2]));
            Assert.That(true, Is.EqualTo(field.Cells[1, 0]));
            Assert.That(true, Is.EqualTo(field.Cells[1, 1]));
            Assert.That(true, Is.EqualTo(field.Cells[1, 2]));
            Assert.That(true, Is.EqualTo(field.Cells[2, 0]));
            Assert.That(true, Is.EqualTo(field.Cells[2, 1]));
            Assert.That(true, Is.EqualTo(field.Cells[2, 2]));
        }

        [Test]
        public void AreAllDead_AllFalse_True()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] = false; field.Cells[0, 2] = false;
            field.Cells[1, 0] = false; field.Cells[1, 1] = false; field.Cells[1, 2] = false;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;
            var expected = true;

            var actual = field.AreAllDead();

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void AreAllDead_OneTrue_False()
        {
            var field = new Field(3, 3);
            field.Cells[0, 0] = false; field.Cells[0, 1] = false; field.Cells[0, 2] = false;
            field.Cells[1, 0] = false; field.Cells[1, 1] =  true; field.Cells[1, 2] = false;
            field.Cells[2, 0] = false; field.Cells[2, 1] = false; field.Cells[2, 2] = false;
            var expected = false;

            var actual = field.AreAllDead();

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
