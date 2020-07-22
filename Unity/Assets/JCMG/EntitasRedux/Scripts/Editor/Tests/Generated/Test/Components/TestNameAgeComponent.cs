//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public EntitasRedux.Tests.NameAgeComponent NameAge { get { return (EntitasRedux.Tests.NameAgeComponent)GetComponent(TestComponentsLookup.NameAge); } }
    public bool HasNameAge { get { return HasComponent(TestComponentsLookup.NameAge); } }

    public void AddNameAge(string newName, int newAge) {
        var index = TestComponentsLookup.NameAge;
        var component = (EntitasRedux.Tests.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.NameAgeComponent));
        component.name = newName;
        component.age = newAge;
        AddComponent(index, component);
    }

    public void ReplaceNameAge(string newName, int newAge) {
        var index = TestComponentsLookup.NameAge;
        var component = (EntitasRedux.Tests.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.NameAgeComponent));
        component.name = newName;
        component.age = newAge;
        ReplaceComponent(index, component);
    }

    public void RemoveNameAge() {
        RemoveComponent(TestComponentsLookup.NameAge);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity : INameAgeEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherNameAge;

    public static JCMG.EntitasRedux.IMatcher<TestEntity> NameAge {
        get {
            if (_matcherNameAge == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.NameAge);
                matcher.ComponentNames = TestComponentsLookup.ComponentNames;
                _matcherNameAge = matcher;
            }

            return _matcherNameAge;
        }
    }
}
