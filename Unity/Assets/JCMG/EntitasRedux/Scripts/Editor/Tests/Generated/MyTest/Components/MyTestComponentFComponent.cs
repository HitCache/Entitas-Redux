//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class MyTestEntity
{
	static readonly EntitasRedux.Tests.ComponentF ComponentFComponent = new EntitasRedux.Tests.ComponentF();

	public bool IsComponentF
	{
		get { return HasComponent(MyTestComponentsLookup.ComponentF); }
		set
		{
			if (value != IsComponentF)
			{
				var index = MyTestComponentsLookup.ComponentF;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: ComponentFComponent;

					AddComponent(index, component);
				}
				else
				{
					RemoveComponent(index);
				}
			}
		}
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class MyTestMatcher
{
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherComponentF;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> ComponentF
	{
		get
		{
			if (_matcherComponentF == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.ComponentF);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherComponentF = matcher;
			}

			return _matcherComponentF;
		}
	}
}
