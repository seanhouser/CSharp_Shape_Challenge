Write a set of classes that derive from a common interface called IShape.  The only requirement of the IShape interface is that it returns the area of any shape that implements it.


Write an implementation of the interface for a triangle (properties: base and height), rectangle (properties: length and width), and circle (properties: diameter and radius).  The circle must be able to be manipulated via a radius and a diameter, and both properties must remain in sync.  I.e. Setting the radius to 2 means the diameter reads 4, and vise versa.

Write a container class that also implements the IShape interface, made to contain any implementation of the IShape interface.  The area property of this class should return the summed area of all IShape objects it contains.  Take measures to prevent infinite loops from occurring if an attempt is made to add the container to itself or a child that it owns at any level (included nested children).  For instance, if Container A holds Container B, and an attempt is made to add Container A to Container B; this should be prevented.

Provide any commenting that you would regularly provide in your own code, and/or as you feel is necessary.