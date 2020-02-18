C# File Layout
==============

Templates for configuration file layout in Rider and Resharper (R#).

Layouts are provided for both Style Cop analyser order, and the .NET API
documentation order.

Versions are provided with regions for each section, for debugging. Using the
layouts with regions with the example class (which has examples of all types of 
elements) will show you exactly what ends up matched to each entry.

If the layout isn't working, add a test case scenario to the example class
(and save it before cleanup); then use the version with regions to make changes, 
and test that it is working correctly.

A PowerShell script is provided that will then convert the version with regions
to a regionless version (it simply removes the regions). Normally the regionless
version would be used.

Note that often many of the subcategories will be empty, e.g. inner enums, interfaces,
etc are rare, and it would be unusual for class to have more than the basic categories.

Differences
-----------

The major differences between the Style Cop and Documentation layouts are:
* Style Cop has fields first; Documentation has constructors first.
* Style Cop has events before properties and methods; Documentation has them after.
* Style Cop has a separate section for indexers; Documentation includes them in fields.
* Style Cop includes operators in methods; Documentation has them separate.
* Style Cop includes explicit interface implementations in each section; Documentation lists them separately.

Note that for the interface implementations, Style Cop provides the suggestion to use partial
classes to keep them separate if desired.

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

Explicit interface implementations of events, properties (& indexers), and methods, are included 
in the public API section.

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

Some example documentation:
* Constructors, Fields, Properties, Methods, Operators, Explicit interfaces implementations: https://docs.microsoft.com/en-us/dotnet/api/system.datetimeoffset?view=netcore-3.1#constructors
* Indexers: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1#properties
* Events: https://docs.microsoft.com/en-us/dotnet/api/system.net.webclient?view=netcore-3.1
