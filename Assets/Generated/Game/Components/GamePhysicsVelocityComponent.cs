//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Physics.VelocityComponent physicsVelocity { get { return (Physics.VelocityComponent)GetComponent(GameComponentsLookup.PhysicsVelocity); } }
    public bool hasPhysicsVelocity { get { return HasComponent(GameComponentsLookup.PhysicsVelocity); } }

    public void AddPhysicsVelocity(UnityEngine.Vector3 newLinear, UnityEngine.Vector3 newAngular) {
        var index = GameComponentsLookup.PhysicsVelocity;
        var component = (Physics.VelocityComponent)CreateComponent(index, typeof(Physics.VelocityComponent));
        component.Linear = newLinear;
        component.Angular = newAngular;
        AddComponent(index, component);
    }

    public void ReplacePhysicsVelocity(UnityEngine.Vector3 newLinear, UnityEngine.Vector3 newAngular) {
        var index = GameComponentsLookup.PhysicsVelocity;
        var component = (Physics.VelocityComponent)CreateComponent(index, typeof(Physics.VelocityComponent));
        component.Linear = newLinear;
        component.Angular = newAngular;
        ReplaceComponent(index, component);
    }

    public void RemovePhysicsVelocity() {
        RemoveComponent(GameComponentsLookup.PhysicsVelocity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPhysicsVelocity;

    public static Entitas.IMatcher<GameEntity> PhysicsVelocity {
        get {
            if (_matcherPhysicsVelocity == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PhysicsVelocity);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPhysicsVelocity = matcher;
            }

            return _matcherPhysicsVelocity;
        }
    }
}
