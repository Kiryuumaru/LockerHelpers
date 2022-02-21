# Locker Helpers

Provides helpers for execution locking mechanism. Can be used for heavy multi threading operations.

**NuGets**

|Name|Info|
| ------------------- | :------------------: |
|LockerHelpers|[![NuGet](https://buildstats.info/nuget/LockerHelpers?includePreReleases=true)](https://www.nuget.org/packages/LockerHelpers/)|

## Installation
```csharp
// Install release version
Install-Package LockerHelpers

// Install pre-release version
Install-Package LockerHelpers -pre
```

## Supported frameworks
.NET Standard 2.0 and above - see https://github.com/dotnet/standard/blob/master/docs/versions.md for compatibility matrix

## Usage

### RWLock Sample
```csharp
using LockerHelpers;

namespace YourNamespace
{
    public class SafeList<T>
    {
        private List<T> list = new List<T>;
        private RWLock rwLock = new RWLock();

        public int Count
        {
            get
            {
                return rwLock.LockRead(() => list.Count);
            }
        }

        public void SafeAdd(T value)
        {
            rwLock.LockWrite(() => list.Add(value));
        }

        public void SafeRemove(T value)
        {
            rwLock.LockWrite(() => list.Remove(value));
        }
    }
}
```

### Want To Support This Project?
All I have ever asked is to be active by submitting bugs, features, and sending those pull requests down!.
