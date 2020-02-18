C# File Layout
==============

Templates for configuration file layout in Rider and Resharper.

Versions are provided with regions for each section, for debugging. Using these 
will show you exactly what ends up matched to each entry.

If the layout isn't working, add a test case scenario to the example class
(and save it before cleanup); then use the version with regions to make changes, 
and test that it is working correctly.

A PowerShell script is provided that will then convert the version with regions
to a regionless version (it simply removes the regions), which is the one you
would normally  use.

Style Cop Layout
----------------

This matches the order specified in the Style Cop analyser rule SA2101.

https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/SA1201.md

This order is:
* Fields
* Constructors
* Finalizers (Destructors)
* Delegates
* Events
* Enums
* Interfaces
* Properties
* Indexers
* Methods (includes Operators)
* Structs
* Classes

Within each category, elements are group by whether they are part of the public API (public 
or protected) or not (internal or private), and then sorted alphabetically by name.

Explicit interface implementations of events, properties, and methods, are included in the
private section.

To group elements like interface implementations together, the rule suggests using partial
classes (one for the main class, one for the interface elements).

Documentation Layout
--------------------

This follows the format used in the .NET API documentation. 

The order used is:
* Constructors (and Finalizers)
* Fields
* Properties (and Indexers)
* Methods
* Operators
* Events
* Explicit interface implementations
* Other items (delegates, enums, interfaces, structs, classes)

Within each category, elements are group by whether they are part of the public API (public, 
protected, or protected internal) or not (internal or private), and then sorted alphabetically 
by name.

In the API documentation all accessible members of each kind are listed together in
alphabetical order, with the features (protected, static, etc) usually indicated by an
icon or flag.

In the documentation, inner delegates, enums, interfaces, structs, and classes, are
documented on separate pages. These constructs are relatively uncommon.
