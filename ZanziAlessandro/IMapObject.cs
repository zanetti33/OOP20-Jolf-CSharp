using System;

namespace ZanziAlessandro
{
    public interface IMapObject
    {
        Point2D GetPosition();
        void Draw();
        void ApplyConstraintTo();
    }
}