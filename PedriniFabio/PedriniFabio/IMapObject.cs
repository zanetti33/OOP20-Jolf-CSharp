using System;
using System.Drawing;

namespace PedriniFabio
{
    public interface IMapObject
    {
        Point2D GetPosition();
        void Draw();
        void ApplyConstraintTo();
    }
}