# <a id="HarpEngine_Entities"></a> Class Entities

Namespace: [HarpEngine](HarpEngine.md)  
Assembly: HarpEngine.dll  

```csharp
public class Entities
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entities](HarpEngine.Entities.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="HarpEngine_Entities_InDrawOrder"></a> InDrawOrder

```csharp
public IEnumerable<Entity> InDrawOrder { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Entity](HarpEngine.Entity.md)\>

### <a id="HarpEngine_Entities_InUpdateOrder"></a> InUpdateOrder

```csharp
public IEnumerable<Entity> InUpdateOrder { get; }
```

#### Property Value

 [IEnumerable](https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable\-1)<[Entity](HarpEngine.Entity.md)\>

## Methods

### <a id="HarpEngine_Entities_DrawDebug_System_Int32_System_Int32_"></a> DrawDebug\(int, int\)

```csharp
public void DrawDebug(int fontSize, int spacing)
```

#### Parameters

`fontSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`spacing` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Entities_GetEntities__1"></a> GetEntities<EntityType\>\(\)

```csharp
public IReadOnlyList<EntityType> GetEntities<EntityType>() where EntityType : Entity
```

#### Returns

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<EntityType\>

#### Type Parameters

`EntityType` 

### <a id="HarpEngine_Entities_GetEntity__1"></a> GetEntity<EntityType\>\(\)

```csharp
public EntityType GetEntity<EntityType>() where EntityType : Entity
```

#### Returns

 EntityType

#### Type Parameters

`EntityType` 

### <a id="HarpEngine_Entities_MoveDrawLayer_HarpEngine_Entity_"></a> MoveDrawLayer\(Entity\)

```csharp
public void MoveDrawLayer(Entity entity)
```

#### Parameters

`entity` [Entity](HarpEngine.Entity.md)

### <a id="HarpEngine_Entities_MoveUpdateLayer_HarpEngine_Entity_"></a> MoveUpdateLayer\(Entity\)

```csharp
public void MoveUpdateLayer(Entity entity)
```

#### Parameters

`entity` [Entity](HarpEngine.Entity.md)

