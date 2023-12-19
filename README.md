A rotating drum has been created that changes its color, with spheres inside (the number of spheres is adjustable, thanks to the script on the SphereSpawner object).

1. Drum: a single object assembled from several primitives. Suspended motionless in space. The outer walls of the drum are made of 6 primitive Cubes, stretched accordingly, and folded together into a kind of box with emptiness inside. The drum rotates constantly around the Z axis at a constant speed using the Motor property of the Hinge Joint. The front and back walls (located on the axis of rotation) are transparent.

2. Spheres: The number of physical spheres that are inside the reel is configured in the Spawner script on the parent SphereSpawner object. The spheres are given jumping properties using physical material.
