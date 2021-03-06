//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public TagsListComponent tagsList { get { return (TagsListComponent)GetComponent(GameComponentsLookup.TagsList); } }
    public bool hasTagsList { get { return HasComponent(GameComponentsLookup.TagsList); } }

    public void AddTagsList(System.Collections.Generic.HashSet<Ecs.Components.GameTag> newValue) {
        var index = GameComponentsLookup.TagsList;
        var component = (TagsListComponent)CreateComponent(index, typeof(TagsListComponent));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTagsList(System.Collections.Generic.HashSet<Ecs.Components.GameTag> newValue) {
        var index = GameComponentsLookup.TagsList;
        var component = (TagsListComponent)CreateComponent(index, typeof(TagsListComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTagsList() {
        RemoveComponent(GameComponentsLookup.TagsList);
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

    static Entitas.IMatcher<GameEntity> _matcherTagsList;

    public static Entitas.IMatcher<GameEntity> TagsList {
        get {
            if (_matcherTagsList == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TagsList);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTagsList = matcher;
            }

            return _matcherTagsList;
        }
    }
}
