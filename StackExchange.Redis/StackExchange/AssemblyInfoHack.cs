﻿// Yes, this is embarassing. However, in .NET Core the including AssemblyInfo (ifdef'd or not) will screw with
// your version numbers. Therefore, we need to move the attribute out into another file...this file.
// When .csproj merges in, this should be able to return to Properties/AssemblyInfo.cs
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("StackExchange.Redis.Tests, PublicKey=00240000048000009400000006020000002400005253413100040000010001007791a689e9d8950b44a9a8886baad2ea180e7a8a854f158c9b98345ca5009cdd2362c84f368f1c3658c132b3c0f74e44ff16aeb2e5b353b6e0fe02f923a050470caeac2bde47a2238a9c7125ed7dab14f486a5a64558df96640933b9f2b6db188fc4a820f96dce963b662fa8864adbff38e5b4542343f162ecdc6dad16912fff")]
