//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class PhysicsComponentsLookup {

    public const int PhysicsCollisionList = 0;
    public const int PhysicsGeneration = 1;
    public const int PhysicsSimulation = 2;
    public const int PhysicsStep = 3;
    public const int PhysicsWorld = 4;

    public const int TotalComponents = 5;

    public static readonly string[] componentNames = {
        "PhysicsCollisionList",
        "PhysicsGeneration",
        "PhysicsSimulation",
        "PhysicsStep",
        "PhysicsWorld"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Physics.CollisionListComponent),
        typeof(Physics.GenerationComponent),
        typeof(Physics.SimulationComponent),
        typeof(Physics.StepComponent),
        typeof(Physics.WorldComponent)
    };
}
