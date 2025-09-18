# Transforms
> `using HarpEngine.Utilities;`

The `Transform2D` class contains properties for:

- `WorldPosition`
- `LocalPosition`
- `WorldRotation`
- `LocalRotation`
- `Parent`
- `Matrix`
- `MatrixInverse`

`Transform2D` should be added to entities if they require position/rotation child-parent relationships. It should be used in place of `Vector3 Position` or `float Rotation`, unless it is not needed. Transformation calculations are not super cheap, and this class has not been super optimized.