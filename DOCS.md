# ZPinball Documentation

## Physics
Handler for the entire physics simulation

#### Properties

| Name | Description |
| --- | --- |
| `Table` | The main `Table` instance |
| `Elements` | A `List` of all `Element` instances that are simulated in physics |

## Table
Acts as a container and manager for all elements, including balls.

#### Properties

| Name | Description |
| --- | --- |
| `Position` | Location in 2D space |
| `Size` | Width and height of the table |
| `Angle` | Angle of the slope from top to bottom |
| `Elements` | `List` of all `Element` instances on the table, excluding balls, which are stored in the `Balls` list instead |
| `Balls` | `List` of `Ball` instances in play |
| `Origin` | The center point of the table |
| `Extents` | Rectangle with the position and size of the table |

## Element
Abstract class used as a base for all objects on the Table. Exists in 3D space.

#### Properties

| Name | Description |
| --- | --- |
| `Position` | Location in 3D space |
| `Shape` | Shape representing the element in 2D space |
| `PhysicsMaterial` | Physical properties of the ball (May be null if element is not simulated in physics) |
| `Collider` | `CircleCollider` of the ball (May be null if element is not simulated in physics) |
| `Velocity` | `Vector2` for calculating the change in position over time, only used if this element is simulated in physics |
| `Acceleration` | `Vector2` for calculating the change in velocity over time, only used if this element is simulated in physics |


### Ball
A pinball, affected by physics. Exists in 3D space.

#### Properties

| Name | Description |
| --- | --- |
| `` |  |

## PhysicsMaterial
Data container with information about how an element should behave in the physics simulation.

#### Properties

| Name | Description |
| --- | --- |
| `Mass` | Currently unused. |
| `Bounce` | How much of the velocity should be retained when bouncing off of another object |
| `Absorb` | If true, subtract bounciness from colliding objects instead of adding |

## Shape
Abstract class used as a base for all other shapes. Exists in 2D space.

Shapes are a visual representation of an Element.

#### Properties

| Name | Description |
| --- | --- |
| `Position` | Location in 2D space |

### CircleShape
Circle shape with a radius.

#### Properties

| Name | Description |
| --- | --- |
| `Radius` | Radius of the circle in degrees |

### PolyShape
Polygon shape defined with a list of points (Vector2).

#### Properties

| Name | Description |
| --- | --- |
| `Points` | A `List` of `Vector2` points ordered by how they should be connected with lines |

## Collider
Abstract class used as a base for all other colliders. Exists in 3D space.

#### Properties

| Name | Description |
| --- | --- |
| `Position` | Location in 3D space |
| `Active` | When false, do not check collisions with other colliders |

### CircleCollider
Circle collider with a radius.

#### Properties

| Name | Description |
| --- | --- |
| `Radius` | Radius of the circle in degrees |

### PolyCollider
Polygon collider defined with a list of points (Vector3);

#### Properties

| Name | Description |
| --- | --- |
| `Points` | A `List` of `Vector3` points ordered by how they should be connected with lines |