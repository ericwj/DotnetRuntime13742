## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_NoInlining()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F0
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,32
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+28]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdi,[rdi+8]
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M00_L01
       add       rdi,10
       xor       ebx,ebx
M00_L00:
       lea       rdx,[rsp+28]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.A, Benchmarks]](Byte ByRef, Benchmarks.A ByRef)
       lea       rdx,[rsp+2C]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.B, Benchmarks]](Byte ByRef, Benchmarks.B ByRef)
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.C, Benchmarks]](Byte ByRef, Benchmarks.C ByRef)
       lea       rdx,[rsp+38]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.D, Benchmarks]](Byte ByRef, Benchmarks.D ByRef)
       lea       rdx,[rsp+40]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.E, Benchmarks]](Byte ByRef, Benchmarks.E ByRef)
       lea       rdx,[rsp+48]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.F, Benchmarks]](Byte ByRef, Benchmarks.F ByRef)
       lea       rdx,[rsp+50]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](Byte ByRef, Benchmarks.G ByRef)
       lea       rdx,[rsp+58]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](Byte ByRef, Benchmarks.H ByRef)
       lea       rdx,[rsp+60]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](Byte ByRef, Benchmarks.I ByRef)
       lea       rdx,[rsp+68]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](Byte ByRef, Benchmarks.J ByRef)
       lea       rdx,[rsp+70]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](Byte ByRef, Benchmarks.K ByRef)
       lea       rdx,[rsp+78]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](Byte ByRef, Benchmarks.L ByRef)
       lea       rdx,[rsp+80]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](Byte ByRef, Benchmarks.M ByRef)
       lea       rdx,[rsp+88]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](Byte ByRef, Benchmarks.N ByRef)
       lea       rdx,[rsp+90]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](Byte ByRef, Benchmarks.O ByRef)
       lea       rdx,[rsp+98]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](Byte ByRef, Benchmarks.P ByRef)
       lea       rdx,[rsp+0A0]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](Byte ByRef, Benchmarks.Q ByRef)
       lea       rdx,[rsp+0A8]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](Byte ByRef, Benchmarks.R ByRef)
       lea       rdx,[rsp+0B0]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](Byte ByRef, Benchmarks.S ByRef)
       lea       rdx,[rsp+0B8]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](Byte ByRef, Benchmarks.T ByRef)
       lea       rdx,[rsp+0C0]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](Byte ByRef, Benchmarks.U ByRef)
       lea       rdx,[rsp+0C8]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](Byte ByRef, Benchmarks.V ByRef)
       lea       rdx,[rsp+0D0]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](Byte ByRef, Benchmarks.W ByRef)
       lea       rdx,[rsp+0D8]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](Byte ByRef, Benchmarks.X ByRef)
       lea       rdx,[rsp+0E0]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](Byte ByRef, Benchmarks.Y ByRef)
       lea       rdx,[rsp+0E8]
       mov       rcx,rdi
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](Byte ByRef, Benchmarks.Z ByRef)
       inc       ebx
       cmp       ebx,44521
       jl        near ptr M00_L00
       mov       rcx,rsi
       lea       rdx,[rsp+28]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,0F0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 507
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.A, Benchmarks]](Byte ByRef, Benchmarks.A ByRef)
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.B, Benchmarks]](Byte ByRef, Benchmarks.B ByRef)
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.C, Benchmarks]](Byte ByRef, Benchmarks.C ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.C ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.D, Benchmarks]](Byte ByRef, Benchmarks.D ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.D ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.E, Benchmarks]](Byte ByRef, Benchmarks.E ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.E ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.F, Benchmarks]](Byte ByRef, Benchmarks.F ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.F ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](Byte ByRef, Benchmarks.G ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.G ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](Byte ByRef, Benchmarks.H ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.H ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](Byte ByRef, Benchmarks.I ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.I ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](Byte ByRef, Benchmarks.J ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.J ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](Byte ByRef, Benchmarks.K ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.K ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](Byte ByRef, Benchmarks.L ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.L ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](Byte ByRef, Benchmarks.M ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.M ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](Byte ByRef, Benchmarks.N ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.N ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](Byte ByRef, Benchmarks.O ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.O ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](Byte ByRef, Benchmarks.P ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.P ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](Byte ByRef, Benchmarks.Q ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.Q ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](Byte ByRef, Benchmarks.R ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.R ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](Byte ByRef, Benchmarks.S ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.S ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](Byte ByRef, Benchmarks.T ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.T ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](Byte ByRef, Benchmarks.U ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.U ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](Byte ByRef, Benchmarks.V ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.V ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](Byte ByRef, Benchmarks.W ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.W ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](Byte ByRef, Benchmarks.X ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.X ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](Byte ByRef, Benchmarks.Y ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.Y ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](Byte ByRef, Benchmarks.Z ByRef)
       mov       rax,offset Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.Z ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       lea       rax,[rcx+4]
       ret
; Total bytes of code 9
```
```assembly
; Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       lea       rax,[rcx+2]
       ret
; Total bytes of code 11
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.C ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.D ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.E ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.F ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.G ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.H ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.I ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.J ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.K ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.L ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.M ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.N ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.O ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.P ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.Q ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.R ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.S ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.T ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.U ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.V ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.W ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.X ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.Y ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.Z ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       mov       rdx,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       cmp       [rsi],esi
       lea       rdx,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsi+6]
       mov       rax,offset Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       add       rsp,20
       pop       rsi
       jmp       rax
; Total bytes of code 55
```
```assembly
; Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 10
```

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_FullInlining()
       push      rdi
       push      rsi
       sub       rsp,0E8
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,32
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+20]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M00_L01
       add       rdx,10
       xor       ecx,ecx
M00_L00:
       lea       r8,[rsp+20]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rsp+24]
       movzx     eax,word ptr [rdx]
       mov       [r8],ax
       lea       r8,[rsp+28]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+2C]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+2E]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+30]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+34]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+36]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+38]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+3C]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+3E]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+40]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+44]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+46]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+48]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+4C]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+4E]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+50]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+54]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+56]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+58]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+5C]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+5E]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+60]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+64]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+66]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+68]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+6C]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+6E]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+70]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+74]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+76]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+78]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+7C]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+7E]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+80]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+84]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+86]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+88]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+8C]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+8E]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+90]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+94]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+96]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+98]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+9C]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+9E]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+0A0]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+0A4]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+0A6]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+0A8]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+0AC]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+0AE]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+0B0]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+0B4]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+0B6]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+0B8]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+0BC]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+0BE]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+0C0]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+0C4]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+0C6]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+0C8]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+0CC]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+0CE]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+0D0]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+0D4]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+0D6]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+0D8]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+0DC]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+0DE]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       lea       r8,[rsp+0E0]
       mov       eax,[rdx]
       mov       [r8],eax
       lea       r8,[rdx+4]
       lea       rax,[rsp+0E4]
       movzx     r9d,word ptr [r8]
       mov       [rax],r9w
       add       r8,2
       lea       rax,[rsp+0E6]
       movzx     r8d,byte ptr [r8]
       mov       [rax],r8b
       inc       ecx
       cmp       ecx,44521
       jl        near ptr M00_L00
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,0E8
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1296
```

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_InlineFieldReads()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F0
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,32
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+28]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdi,[rdi+8]
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M00_L01
       add       rdi,10
       xor       ebx,ebx
M00_L00:
       lea       rdx,[rsp+28]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.A, Benchmarks]](Byte ByRef, Benchmarks.A ByRef)
       lea       rdx,[rsp+2C]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.B, Benchmarks]](Byte ByRef, Benchmarks.B ByRef)
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.C, Benchmarks]](Byte ByRef, Benchmarks.C ByRef)
       lea       rdx,[rsp+38]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.D, Benchmarks]](Byte ByRef, Benchmarks.D ByRef)
       lea       rdx,[rsp+40]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.E, Benchmarks]](Byte ByRef, Benchmarks.E ByRef)
       lea       rdx,[rsp+48]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.F, Benchmarks]](Byte ByRef, Benchmarks.F ByRef)
       lea       rdx,[rsp+50]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.G, Benchmarks]](Byte ByRef, Benchmarks.G ByRef)
       lea       rdx,[rsp+58]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.H, Benchmarks]](Byte ByRef, Benchmarks.H ByRef)
       lea       rdx,[rsp+60]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.I, Benchmarks]](Byte ByRef, Benchmarks.I ByRef)
       lea       rdx,[rsp+68]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.J, Benchmarks]](Byte ByRef, Benchmarks.J ByRef)
       lea       rdx,[rsp+70]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.K, Benchmarks]](Byte ByRef, Benchmarks.K ByRef)
       lea       rdx,[rsp+78]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.L, Benchmarks]](Byte ByRef, Benchmarks.L ByRef)
       lea       rdx,[rsp+80]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.M, Benchmarks]](Byte ByRef, Benchmarks.M ByRef)
       lea       rdx,[rsp+88]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.N, Benchmarks]](Byte ByRef, Benchmarks.N ByRef)
       lea       rdx,[rsp+90]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.O, Benchmarks]](Byte ByRef, Benchmarks.O ByRef)
       lea       rdx,[rsp+98]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.P, Benchmarks]](Byte ByRef, Benchmarks.P ByRef)
       lea       rdx,[rsp+0A0]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Q, Benchmarks]](Byte ByRef, Benchmarks.Q ByRef)
       lea       rdx,[rsp+0A8]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.R, Benchmarks]](Byte ByRef, Benchmarks.R ByRef)
       lea       rdx,[rsp+0B0]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.S, Benchmarks]](Byte ByRef, Benchmarks.S ByRef)
       lea       rdx,[rsp+0B8]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.T, Benchmarks]](Byte ByRef, Benchmarks.T ByRef)
       lea       rdx,[rsp+0C0]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.U, Benchmarks]](Byte ByRef, Benchmarks.U ByRef)
       lea       rdx,[rsp+0C8]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.V, Benchmarks]](Byte ByRef, Benchmarks.V ByRef)
       lea       rdx,[rsp+0D0]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.W, Benchmarks]](Byte ByRef, Benchmarks.W ByRef)
       lea       rdx,[rsp+0D8]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.X, Benchmarks]](Byte ByRef, Benchmarks.X ByRef)
       lea       rdx,[rsp+0E0]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Y, Benchmarks]](Byte ByRef, Benchmarks.Y ByRef)
       lea       rdx,[rsp+0E8]
       mov       rcx,rdi
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Z, Benchmarks]](Byte ByRef, Benchmarks.Z ByRef)
       inc       ebx
       cmp       ebx,44521
       jl        near ptr M00_L00
       mov       rcx,rsi
       lea       rdx,[rsp+28]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,0F0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 507
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.A, Benchmarks]](Byte ByRef, Benchmarks.A ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       lea       rax,[rcx+4]
       ret
; Total bytes of code 9
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.B, Benchmarks]](Byte ByRef, Benchmarks.B ByRef)
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       lea       rax,[rcx+2]
       ret
; Total bytes of code 11
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.C, Benchmarks]](Byte ByRef, Benchmarks.C ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.C ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.D, Benchmarks]](Byte ByRef, Benchmarks.D ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.D ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.E, Benchmarks]](Byte ByRef, Benchmarks.E ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.E ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.F, Benchmarks]](Byte ByRef, Benchmarks.F ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.F ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.G, Benchmarks]](Byte ByRef, Benchmarks.G ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.G ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.H, Benchmarks]](Byte ByRef, Benchmarks.H ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.H ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.I, Benchmarks]](Byte ByRef, Benchmarks.I ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.I ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.J, Benchmarks]](Byte ByRef, Benchmarks.J ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.J ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.K, Benchmarks]](Byte ByRef, Benchmarks.K ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.K ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.L, Benchmarks]](Byte ByRef, Benchmarks.L ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.L ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.M, Benchmarks]](Byte ByRef, Benchmarks.M ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.M ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.N, Benchmarks]](Byte ByRef, Benchmarks.N ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.N ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.O, Benchmarks]](Byte ByRef, Benchmarks.O ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.O ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.P, Benchmarks]](Byte ByRef, Benchmarks.P ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.P ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Q, Benchmarks]](Byte ByRef, Benchmarks.Q ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.Q ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.R, Benchmarks]](Byte ByRef, Benchmarks.R ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.R ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.S, Benchmarks]](Byte ByRef, Benchmarks.S ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.S ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.T, Benchmarks]](Byte ByRef, Benchmarks.T ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.T ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.U, Benchmarks]](Byte ByRef, Benchmarks.U ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.U ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.V, Benchmarks]](Byte ByRef, Benchmarks.V ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.V ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.W, Benchmarks]](Byte ByRef, Benchmarks.W ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.W ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.X, Benchmarks]](Byte ByRef, Benchmarks.X ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.X ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Y, Benchmarks]](Byte ByRef, Benchmarks.Y ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.Y ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Z, Benchmarks]](Byte ByRef, Benchmarks.Z ByRef)
       mov       rax,offset Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.Z ByRef)
       jmp       rax
; Total bytes of code 13
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.C ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.D ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.E ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.F ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.G ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.H ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.I ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.J ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.K ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.L ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.M ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.N ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.O ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.P ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.Q ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.R ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.S ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.T ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.U ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.V ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.W ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.X ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.Y ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.Z ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       add       rcx,4
       lea       rax,[rdx+4]
       movzx     r8d,word ptr [rcx]
       mov       [rax],r8w
       add       rcx,2
       add       rdx,6
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 38
```

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_InlineStructReads()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F0
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,32
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+28]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdi,[rdi+8]
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M00_L01
       add       rdi,10
       xor       ebx,ebx
M00_L00:
       lea       rdx,[rsp+28]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       lea       rdx,[rsp+2C]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       lea       rdx,[rsp+30]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+34]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+36]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+38]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+3C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+3E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+40]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+44]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+46]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+48]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+4C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+4E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+50]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+54]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+56]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+58]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+5C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+5E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+60]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+64]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+66]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+68]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+6C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+6E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+70]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+74]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+76]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+78]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+7C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+7E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+80]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+84]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+86]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+88]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+8C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+8E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+90]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+94]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+96]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+98]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+9C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+9E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0A0]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0A4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0A6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0A8]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0AC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0AE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0B0]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0B4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0B6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0B8]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0BC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0BE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0C0]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0C4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0C6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0C8]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0CC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0CE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0D0]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0D4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0D6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0D8]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0DC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0DE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0E0]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0E4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0E6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       lea       rdx,[rsp+0E8]
       mov       rcx,rdi
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0EC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       mov       rcx,rax
       lea       rdx,[rsp+0EE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       inc       ebx
       cmp       ebx,44521
       jl        near ptr M00_L00
       mov       rcx,rsi
       lea       rdx,[rsp+28]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,0F0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1215
```
```assembly
; Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
       mov       eax,[rcx]
       mov       [rdx],eax
       lea       rax,[rcx+4]
       ret
; Total bytes of code 9
```
```assembly
; Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
       movzx     eax,word ptr [rcx]
       mov       [rdx],ax
       lea       rax,[rcx+2]
       ret
; Total bytes of code 11
```
```assembly
; Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 10
```

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_ManualFieldForField()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E8
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,32
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+20]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M00_L01
       add       rdx,10
       xor       ecx,ecx
       lea       r8,[rdx+4]
       lea       rax,[rdx+4]
       lea       r9,[rdx+4]
       lea       r10,[rdx+4]
       lea       r11,[rdx+4]
       lea       rdi,[rdx+4]
       lea       rbx,[rdx+4]
       lea       rbp,[rdx+4]
       lea       r14,[rdx+4]
       lea       r15,[rdx+4]
M00_L00:
       mov       r12d,[rdx]
       mov       [rsp+20],r12d
       movzx     r12d,word ptr [rdx]
       mov       [rsp+24],r12w
       mov       r12d,[rdx]
       mov       [rsp+28],r12d
       mov       r12,r8
       movzx     r13d,word ptr [r12]
       mov       [rsp+2C],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+2E],r12b
       mov       r12d,[rdx]
       mov       [rsp+30],r12d
       mov       r12,rax
       movzx     r13d,word ptr [r12]
       mov       [rsp+34],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+36],r12b
       mov       r12d,[rdx]
       mov       [rsp+38],r12d
       mov       r12,r9
       movzx     r13d,word ptr [r12]
       mov       [rsp+3C],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+3E],r12b
       mov       r12d,[rdx]
       mov       [rsp+40],r12d
       mov       r12,r10
       movzx     r13d,word ptr [r12]
       mov       [rsp+44],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+46],r12b
       mov       r12d,[rdx]
       mov       [rsp+48],r12d
       mov       r12,r11
       movzx     r13d,word ptr [r12]
       mov       [rsp+4C],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+4E],r12b
       mov       r12d,[rdx]
       mov       [rsp+50],r12d
       mov       r12,rdi
       movzx     r13d,word ptr [r12]
       mov       [rsp+54],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+56],r12b
       mov       r12d,[rdx]
       mov       [rsp+58],r12d
       mov       r12,rbx
       movzx     r13d,word ptr [r12]
       mov       [rsp+5C],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+5E],r12b
       mov       r12d,[rdx]
       mov       [rsp+60],r12d
       mov       r12,rbp
       movzx     r13d,word ptr [r12]
       mov       [rsp+64],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+66],r12b
       mov       r12d,[rdx]
       mov       [rsp+68],r12d
       mov       r12,r14
       movzx     r13d,word ptr [r12]
       mov       [rsp+6C],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+6E],r12b
       mov       r12d,[rdx]
       mov       [rsp+70],r12d
       mov       r12,r15
       movzx     r13d,word ptr [r12]
       mov       [rsp+74],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+76],r12b
       mov       r12d,[rdx]
       mov       [rsp+78],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+7C],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+7E],r12b
       mov       r12d,[rdx]
       mov       [rsp+80],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+84],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+86],r12b
       mov       r12d,[rdx]
       mov       [rsp+88],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+8C],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+8E],r12b
       mov       r12d,[rdx]
       mov       [rsp+90],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+94],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+96],r12b
       mov       r12d,[rdx]
       mov       [rsp+98],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+9C],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+9E],r12b
       mov       r12d,[rdx]
       mov       [rsp+0A0],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+0A4],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+0A6],r12b
       mov       r12d,[rdx]
       mov       [rsp+0A8],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+0AC],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+0AE],r12b
       mov       r12d,[rdx]
       mov       [rsp+0B0],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+0B4],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+0B6],r12b
       mov       r12d,[rdx]
       mov       [rsp+0B8],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+0BC],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+0BE],r12b
       mov       r12d,[rdx]
       mov       [rsp+0C0],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+0C4],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+0C6],r12b
       mov       r12d,[rdx]
       mov       [rsp+0C8],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+0CC],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+0CE],r12b
       mov       r12d,[rdx]
       mov       [rsp+0D0],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+0D4],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+0D6],r12b
       mov       r12d,[rdx]
       mov       [rsp+0D8],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+0DC],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+0DE],r12b
       mov       r12d,[rdx]
       mov       [rsp+0E0],r12d
       lea       r12,[rdx+4]
       movzx     r13d,word ptr [r12]
       mov       [rsp+0E4],r13w
       add       r12,2
       movzx     r12d,byte ptr [r12]
       mov       [rsp+0E6],r12b
       inc       ecx
       cmp       ecx,44521
       jl        near ptr M00_L00
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,0E8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1198
```

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_NoInlining()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,298
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,9E
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+1D0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rcx,[rdi+8]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       lea       rdi,[rcx+10]
       mov       ebx,[rcx+8]
M00_L01:
       xor       ebp,ebp
M00_L02:
       lea       rcx,[rsp+1C0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1D0]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.A, Benchmarks]](System.Span`1<Byte>, Benchmarks.A ByRef)
       lea       rcx,[rsp+1B0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1D4]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.B, Benchmarks]](System.Span`1<Byte>, Benchmarks.B ByRef)
       lea       rcx,[rsp+1A0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1D8]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.C, Benchmarks]](System.Span`1<Byte>, Benchmarks.C ByRef)
       lea       rcx,[rsp+190]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1E0]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.D, Benchmarks]](System.Span`1<Byte>, Benchmarks.D ByRef)
       lea       rcx,[rsp+180]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1E8]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.E, Benchmarks]](System.Span`1<Byte>, Benchmarks.E ByRef)
       lea       rcx,[rsp+170]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1F0]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.F, Benchmarks]](System.Span`1<Byte>, Benchmarks.F ByRef)
       lea       rcx,[rsp+160]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1F8]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       lea       rcx,[rsp+150]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+200]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       lea       rcx,[rsp+140]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+208]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       lea       rcx,[rsp+130]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+210]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       lea       rcx,[rsp+120]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+218]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       lea       rcx,[rsp+110]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+220]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       lea       rcx,[rsp+100]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+228]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       lea       rcx,[rsp+0F0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+230]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       lea       rcx,[rsp+0E0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+238]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       lea       rcx,[rsp+0D0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+240]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       lea       rcx,[rsp+0C0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+248]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       lea       rcx,[rsp+0B0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+250]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       lea       rcx,[rsp+0A0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+258]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       lea       rcx,[rsp+90]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+260]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+268]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       lea       rcx,[rsp+70]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+270]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+278]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+280]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+288]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+290]
       call      Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       inc       ebp
       cmp       ebp,44521
       jl        near ptr M00_L02
       mov       rcx,rsi
       lea       rdx,[rsp+1D0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,298
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 1080
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.A, Benchmarks]](System.Span`1<Byte>, Benchmarks.A ByRef)
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       rax,rsi
       lea       r9,[rsp+20]
       mov       [r9],rcx
       mov       [r9+8],edx
       mov       rcx,rax
       lea       rdx,[rsp+20]
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.B, Benchmarks]](System.Span`1<Byte>, Benchmarks.B ByRef)
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rdx]
       mov       edx,[rdx+8]
       mov       rax,rsi
       lea       r9,[rsp+20]
       mov       [r9],rcx
       mov       [r9+8],edx
       mov       rcx,rax
       lea       rdx,[rsp+20]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rax,rsi
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.C, Benchmarks]](System.Span`1<Byte>, Benchmarks.C ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.C ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.D, Benchmarks]](System.Span`1<Byte>, Benchmarks.D ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.D ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.E, Benchmarks]](System.Span`1<Byte>, Benchmarks.E ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.E ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.F, Benchmarks]](System.Span`1<Byte>, Benchmarks.F ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.F ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.G ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.H ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.I ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.J ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.K ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.L ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.M ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.N ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.O ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.P ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Q ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.R ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.S ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.T ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.U ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.V ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.W ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.X ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Y ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Z ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       cmp       edx,4
       jl        short M27_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M27_L01
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M27_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M27_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 70
```
```assembly
; Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       cmp       edx,2
       jl        short M28_L00
       movzx     r9d,word ptr [rax]
       mov       [r8],r9w
       cmp       edx,2
       jb        short M28_L01
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M28_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M28_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 66
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.C ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.D ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.E ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.F ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.G ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.H ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.I ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.J ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.K ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.L ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.M ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.N ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.O ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.P ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Q ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.R ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.S ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.T ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.U ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.V ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.W ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.X ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Y ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Z ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,0C
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,r8
       lea       rcx,[rsp+48]
       mov       r8,rsi
       call      Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       mov       r8,[rsp+48]
       mov       [rdx],r8
       mov       r8d,[rsp+50]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       cmp       [rsi],esi
       lea       r8,[rsi+4]
       call      Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,rdi
       lea       rdx,[rsp+28]
       mov       r8,[rsp+38]
       mov       [rdx],r8
       mov       r8d,[rsp+40]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+28]
       lea       r8,[rsi+6]
       call      Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rax,rdi
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       cmp       edx,0
       jbe       short M53_L01
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M53_L00
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M53_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M53_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_FullInlining()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,970
       vzeroupper
       mov       rsi,rcx
       lea       rdi,[rsp+28]
       mov       ecx,252
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+8A8]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rax,[rdi+8]
       lea       rdx,[rsp+6E8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       test      rax,rax
       jne       short M00_L00
       lea       rax,[rsp+6E8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       jmp       short M00_L01
M00_L00:
       lea       rdx,[rax+10]
       mov       [rsp+6E0],rdx
       mov       rdx,[rsp+6E0]
       lea       rcx,[rsp+6E8]
       mov       [rcx],rdx
       mov       eax,[rax+8]
       mov       [rsp+6F0],eax
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+6E8]
       vmovdqu   xmmword ptr [rsp+898],xmm0
       xor       edi,edi
M00_L02:
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+6C0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+6C0]
       vmovdqu   xmmword ptr [rsp+6B0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+6B0]
       vmovdqu   xmmword ptr [rsp+690],xmm0
       xor       eax,eax
       mov       [rsp+68C],eax
       vmovdqu   xmm0,xmmword ptr [rsp+690]
       vmovdqu   xmmword ptr [rsp+668],xmm0
       lea       rax,[rsp+658]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+668]
       mov       rdx,rax
       mov       ecx,[rsp+670]
       mov       r8d,ecx
       mov       [rsp+650],rdx
       mov       rdx,[rsp+650]
       lea       r9,[rsp+658]
       mov       [r9],rdx
       mov       [rsp+660],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+658]
       vmovdqu   xmmword ptr [rsp+678],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+678]
       vmovdqu   xmmword ptr [rsp+640],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+640]
       vmovdqu   xmmword ptr [rsp+630],xmm0
       cmp       dword ptr [rsp+638],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+630]
       vmovdqu   xmmword ptr [rsp+620],xmm0
       mov       rdx,[rsp+620]
       mov       edx,[rdx]
       lea       r8,[rsp+8A8]
       mov       [r8],edx
       cmp       ecx,4
       jb        near ptr M00_L06
       mov       rdx,rax
       lea       r8,[rsp+610]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r8],xmm0
       lea       r8d,[rcx+0FFFC]
       mov       r9d,r8d
       add       rdx,4
       mov       [rsp+608],rdx
       mov       r10,[rsp+608]
       lea       r11,[rsp+610]
       mov       [r11],r10
       mov       [rsp+618],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+610]
       vmovdqu   xmmword ptr [rsp+6A0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+6A0]
       vmovdqu   xmmword ptr [rsp+6D0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+6D0]
       vmovdqu   xmmword ptr [rsp+888],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+5E8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+5E8]
       vmovdqu   xmmword ptr [rsp+5D8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+5D8]
       vmovdqu   xmmword ptr [rsp+5B8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+5B8]
       vmovdqu   xmmword ptr [rsp+598],xmm0
       lea       r9,[rsp+588]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r9],xmm0
       mov       r9,rax
       mov       r10d,ecx
       mov       [rsp+580],r9
       mov       r9,[rsp+580]
       lea       r11,[rsp+588]
       mov       [r11],r9
       mov       [rsp+590],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+588]
       vmovdqu   xmmword ptr [rsp+5A8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+5A8]
       vmovdqu   xmmword ptr [rsp+570],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+570]
       vmovdqu   xmmword ptr [rsp+560],xmm0
       cmp       dword ptr [rsp+568],2
       jl        near ptr M00_L07
       vmovdqu   xmm0,xmmword ptr [rsp+560]
       vmovdqu   xmmword ptr [rsp+550],xmm0
       mov       r9,[rsp+550]
       movzx     r9d,word ptr [r9]
       lea       r10,[rsp+8AC]
       mov       [r10],r9w
       cmp       ecx,2
       jb        near ptr M00_L08
       mov       r9,rax
       lea       r10,[rsp+540]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r10],xmm0
       lea       r10d,[rcx+0FFFE]
       add       r9,2
       mov       [rsp+538],r9
       mov       r9,[rsp+538]
       lea       r11,[rsp+540]
       mov       [r11],r9
       mov       [rsp+548],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+540]
       vmovdqu   xmmword ptr [rsp+5C8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+5C8]
       vmovdqu   xmmword ptr [rsp+5F8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+5F8]
       vmovdqu   xmmword ptr [rsp+878],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+518],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+508],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+508]
       vmovdqu   xmmword ptr [rsp+4C8],xmm0
       xor       r9d,r9d
       mov       [rsp+4C4],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+4C8]
       vmovdqu   xmmword ptr [rsp+4A0],xmm0
       lea       r9,[rsp+490]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r9],xmm0
       mov       r9,rax
       mov       r10d,ecx
       mov       [rsp+488],r9
       mov       r9,[rsp+488]
       lea       r11,[rsp+490]
       mov       [r11],r9
       mov       [rsp+498],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+490]
       vmovdqu   xmmword ptr [rsp+4B0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+4B0]
       vmovdqu   xmmword ptr [rsp+478],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+478]
       vmovdqu   xmmword ptr [rsp+468],xmm0
       cmp       dword ptr [rsp+470],4
       jl        near ptr M00_L09
       vmovdqu   xmm0,xmmword ptr [rsp+468]
       vmovdqu   xmmword ptr [rsp+458],xmm0
       mov       r9,[rsp+458]
       mov       r9d,[r9]
       lea       r10,[rsp+8B0]
       mov       [r10],r9d
       cmp       ecx,4
       jb        near ptr M00_L10
       lea       r9,[rsp+448]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r9],xmm0
       mov       r9d,r8d
       mov       [rsp+440],rdx
       mov       r10,[rsp+440]
       lea       r11,[rsp+448]
       mov       [r11],r10
       mov       [rsp+450],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+448]
       vmovdqu   xmmword ptr [rsp+4D8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+4D8]
       vmovdqu   xmmword ptr [rsp+4F8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+4F8]
       vmovdqu   xmmword ptr [rsp+420],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+420]
       vmovdqu   xmmword ptr [rsp+400],xmm0
       lea       r9,[rsp+3F0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r9],xmm0
       mov       r9,[rsp+400]
       mov       r10d,[rsp+408]
       mov       [rsp+3E8],r9
       mov       r9,[rsp+3E8]
       lea       r11,[rsp+3F0]
       mov       [r11],r9
       mov       [rsp+3F8],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+3F0]
       vmovdqu   xmmword ptr [rsp+410],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+410]
       vmovdqu   xmmword ptr [rsp+3D8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+3D8]
       vmovdqu   xmmword ptr [rsp+3C8],xmm0
       cmp       dword ptr [rsp+3D0],2
       jl        near ptr M00_L11
       vmovdqu   xmm0,xmmword ptr [rsp+3C8]
       vmovdqu   xmmword ptr [rsp+3B8],xmm0
       mov       r9,[rsp+3B8]
       movzx     r9d,word ptr [r9]
       lea       r10,[rsp+8B4]
       mov       [r10],r9w
       cmp       dword ptr [rsp+428],2
       jb        near ptr M00_L12
       mov       r9,[rsp+420]
       lea       r10,[rsp+3A8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r10],xmm0
       mov       r10d,[rsp+428]
       add       r10d,0FFFFFFFE
       add       r9,2
       mov       [rsp+3A0],r9
       mov       r9,[rsp+3A0]
       lea       r11,[rsp+3A8]
       mov       [r11],r9
       mov       [rsp+3B0],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+3A8]
       vmovdqu   xmmword ptr [rsp+430],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+430]
       vmovdqu   xmmword ptr [rsp+4E8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+4E8]
       vmovdqu   xmmword ptr [rsp+380],xmm0
       lea       r9,[rsp+8B6]
       cmp       dword ptr [rsp+388],0
       jbe       near ptr M00_L22
       mov       r10,[rsp+380]
       movzx     r10d,byte ptr [r10]
       mov       [r9],r10b
       cmp       dword ptr [rsp+388],1
       jb        near ptr M00_L13
       mov       r9,[rsp+380]
       lea       r10,[rsp+370]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r10],xmm0
       mov       r10d,[rsp+388]
       dec       r10d
       inc       r9
       mov       [rsp+368],r9
       mov       r9,[rsp+368]
       lea       r11,[rsp+370]
       mov       [r11],r9
       mov       [rsp+378],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+370]
       vmovdqu   xmmword ptr [rsp+390],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+390]
       vmovdqu   xmmword ptr [rsp+528],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+528]
       vmovdqu   xmmword ptr [rsp+868],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+348],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+348]
       vmovdqu   xmmword ptr [rsp+338],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+338]
       vmovdqu   xmmword ptr [rsp+2F8],xmm0
       xor       r9d,r9d
       mov       [rsp+2F4],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+2F8]
       vmovdqu   xmmword ptr [rsp+2D0],xmm0
       lea       r9,[rsp+2C0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r9],xmm0
       mov       r9,rax
       mov       r10d,ecx
       mov       [rsp+2B8],r9
       mov       r9,[rsp+2B8]
       lea       r11,[rsp+2C0]
       mov       [r11],r9
       mov       [rsp+2C8],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+2C0]
       vmovdqu   xmmword ptr [rsp+2E0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+2E0]
       vmovdqu   xmmword ptr [rsp+2A8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+2A8]
       vmovdqu   xmmword ptr [rsp+298],xmm0
       cmp       dword ptr [rsp+2A0],4
       jl        near ptr M00_L14
       vmovdqu   xmm0,xmmword ptr [rsp+298]
       vmovdqu   xmmword ptr [rsp+288],xmm0
       mov       r9,[rsp+288]
       mov       r9d,[r9]
       lea       r10,[rsp+8B8]
       mov       [r10],r9d
       cmp       ecx,4
       jb        near ptr M00_L15
       lea       r9,[rsp+278]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r9],xmm0
       mov       r9d,r8d
       mov       [rsp+270],rdx
       mov       r10,[rsp+270]
       lea       r11,[rsp+278]
       mov       [r11],r10
       mov       [rsp+280],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+278]
       vmovdqu   xmmword ptr [rsp+308],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+308]
       vmovdqu   xmmword ptr [rsp+328],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+328]
       vmovdqu   xmmword ptr [rsp+250],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+250]
       vmovdqu   xmmword ptr [rsp+230],xmm0
       lea       r9,[rsp+220]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r9],xmm0
       mov       r9,[rsp+230]
       mov       r10d,[rsp+238]
       mov       [rsp+218],r9
       mov       r9,[rsp+218]
       lea       r11,[rsp+220]
       mov       [r11],r9
       mov       [rsp+228],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+220]
       vmovdqu   xmmword ptr [rsp+240],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+240]
       vmovdqu   xmmword ptr [rsp+208],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+208]
       vmovdqu   xmmword ptr [rsp+1F8],xmm0
       cmp       dword ptr [rsp+200],2
       jl        near ptr M00_L16
       vmovdqu   xmm0,xmmword ptr [rsp+1F8]
       vmovdqu   xmmword ptr [rsp+1E8],xmm0
       mov       r9,[rsp+1E8]
       movzx     r9d,word ptr [r9]
       lea       r10,[rsp+8BC]
       mov       [r10],r9w
       cmp       dword ptr [rsp+258],2
       jb        near ptr M00_L17
       mov       r9,[rsp+250]
       lea       r10,[rsp+1D8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r10],xmm0
       mov       r10d,[rsp+258]
       add       r10d,0FFFFFFFE
       add       r9,2
       mov       [rsp+1D0],r9
       mov       r9,[rsp+1D0]
       lea       r11,[rsp+1D8]
       mov       [r11],r9
       mov       [rsp+1E0],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+1D8]
       vmovdqu   xmmword ptr [rsp+260],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+260]
       vmovdqu   xmmword ptr [rsp+318],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+318]
       vmovdqu   xmmword ptr [rsp+1B0],xmm0
       lea       r9,[rsp+8BE]
       cmp       dword ptr [rsp+1B8],0
       jbe       near ptr M00_L22
       mov       r10,[rsp+1B0]
       movzx     r10d,byte ptr [r10]
       mov       [r9],r10b
       cmp       dword ptr [rsp+1B8],1
       jb        near ptr M00_L18
       mov       r9,[rsp+1B0]
       lea       r10,[rsp+1A0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r10],xmm0
       mov       r10d,[rsp+1B8]
       dec       r10d
       inc       r9
       mov       [rsp+198],r9
       mov       r9,[rsp+198]
       lea       r11,[rsp+1A0]
       mov       [r11],r9
       mov       [rsp+1A8],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+1A0]
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1C0]
       vmovdqu   xmmword ptr [rsp+358],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+358]
       vmovdqu   xmmword ptr [rsp+858],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+178],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+178]
       vmovdqu   xmmword ptr [rsp+168],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+168]
       vmovdqu   xmmword ptr [rsp+128],xmm0
       xor       r9d,r9d
       mov       [rsp+124],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+128]
       vmovdqu   xmmword ptr [rsp+100],xmm0
       lea       r9,[rsp+0F0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [r9],xmm0
       mov       r9d,ecx
       mov       [rsp+0E8],rax
       mov       rax,[rsp+0E8]
       lea       r10,[rsp+0F0]
       mov       [r10],rax
       mov       [rsp+0F8],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+0F0]
       vmovdqu   xmmword ptr [rsp+110],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+110]
       vmovdqu   xmmword ptr [rsp+0D8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D8]
       vmovdqu   xmmword ptr [rsp+0C8],xmm0
       cmp       dword ptr [rsp+0D0],4
       jl        near ptr M00_L19
       vmovdqu   xmm0,xmmword ptr [rsp+0C8]
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       mov       rax,[rsp+0B8]
       mov       eax,[rax]
       lea       r9,[rsp+8C0]
       mov       [r9],eax
       cmp       ecx,4
       jb        near ptr M00_L20
       lea       rax,[rsp+0A8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       [rsp+0A0],rdx
       mov       rax,[rsp+0A0]
       lea       rdx,[rsp+0A8]
       mov       [rdx],rax
       mov       [rsp+0B0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+0A8]
       vmovdqu   xmmword ptr [rsp+138],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+138]
       vmovdqu   xmmword ptr [rsp+158],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+158]
       vmovdqu   xmmword ptr [rsp+80],xmm0
       xor       eax,eax
       mov       [rsp+68],eax
       call      System.Runtime.CompilerServices.Unsafe.SizeOf[[System.UInt16, System.Private.CoreLib]]()
       cmp       eax,2
       jne       short M00_L03
       lea       rcx,[rsp+70]
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rcx,[rsp+38]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+68],ax
       lea       rbx,[rsp+8C4]
       lea       rcx,[rsp+68]
       call      System.Runtime.CompilerServices.Unsafe.As[[System.UInt16, System.Private.CoreLib],[System.UInt16, System.Private.CoreLib]](UInt16 ByRef)
       movzx     ecx,word ptr [rax]
       mov       [rbx],cx
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+90]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       jmp       short M00_L04
M00_L03:
       call      System.Runtime.CompilerServices.Unsafe.SizeOf[[System.UInt16, System.Private.CoreLib]]()
       cmp       eax,1
       jne       near ptr M00_L21
       lea       rbx,[rsp+8C4]
       cmp       dword ptr [rsp+88],0
       jbe       near ptr M00_L22
       mov       rcx,[rsp+80]
       call      System.Runtime.CompilerServices.Unsafe.As[[System.Byte, System.Private.CoreLib],[System.UInt16, System.Private.CoreLib]](Byte ByRef)
       movzx     ecx,word ptr [rax]
       mov       [rbx],cx
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+90]
       mov       r8d,1
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
M00_L04:
       vmovdqu   xmm0,xmmword ptr [rsp+90]
       vmovdqu   xmmword ptr [rsp+148],xmm0
       lea       rcx,[rsp+188]
       vmovdqu   xmm0,xmmword ptr [rsp+148]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+8C6]
       call      Benchmarks.FullInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       vmovdqu   xmm0,xmmword ptr [rsp+188]
       vmovdqu   xmmword ptr [rsp+848],xmm0
       lea       rcx,[rsp+838]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+8C8]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.F, Benchmarks]](System.Span`1<Byte>, Benchmarks.F ByRef)
       lea       rcx,[rsp+828]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+8D0]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       lea       rcx,[rsp+818]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+8D8]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       lea       rcx,[rsp+808]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+8E0]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       lea       rcx,[rsp+7F8]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+8E8]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       lea       rcx,[rsp+7E8]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+8F0]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       lea       rcx,[rsp+7D8]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+8F8]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       lea       rcx,[rsp+7C8]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+900]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       lea       rcx,[rsp+7B8]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+908]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       lea       rcx,[rsp+7A8]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+910]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       lea       rcx,[rsp+798]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+918]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       lea       rcx,[rsp+788]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+920]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       lea       rcx,[rsp+778]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+928]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       lea       rcx,[rsp+768]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+930]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       lea       rcx,[rsp+758]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+938]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       lea       rcx,[rsp+748]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+940]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       lea       rcx,[rsp+738]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+948]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       lea       rcx,[rsp+728]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+950]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       lea       rcx,[rsp+718]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+958]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       lea       rcx,[rsp+708]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+960]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       lea       rcx,[rsp+6F8]
       vmovdqu   xmm0,xmmword ptr [rsp+898]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       rdx,[rsp+28]
       lea       r8,[rsp+968]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       inc       edi
       cmp       edi,44521
       jl        near ptr M00_L02
       mov       rcx,rsi
       lea       rdx,[rsp+8A8]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,970
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L06:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L07:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L08:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L09:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L10:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L11:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L12:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L14:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L15:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L16:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L17:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L19:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L20:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L21:
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.InvalidCastException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 4418
```
```assembly
; System.Runtime.CompilerServices.Unsafe.SizeOf[[System.UInt16, System.Private.CoreLib]]()
       mov       eax,2
       ret
; Total bytes of code 6
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
```
```assembly
; System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       sub       rsp,28
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       cmp       ecx,2
       jl        short M03_L00
       movzx     eax,word ptr [rax]
       add       rsp,28
       ret
M03_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 34
```
```assembly
; System.Runtime.CompilerServices.Unsafe.As[[System.UInt16, System.Private.CoreLib],[System.UInt16, System.Private.CoreLib]](UInt16 ByRef)
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       r8d,eax
       ja        short M05_L00
       mov       rcx,[rcx]
       sub       eax,r8d
       movsxd    r8,r8d
       add       rcx,r8
       mov       [rdx],rcx
       mov       [rdx+8],eax
       mov       rax,rdx
       add       rsp,28
       ret
M05_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 44
```
```assembly
; Benchmarks.FullInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       cmp       edx,0
       jbe       short M06_L01
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M06_L00
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M06_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M06_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.F, Benchmarks]](System.Span`1<Byte>, Benchmarks.F ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M07_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M07_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M07_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M07_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M07_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M07_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M07_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M07_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M07_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M07_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M07_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M07_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M08_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M08_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M08_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M08_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M08_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M08_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M08_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M08_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M08_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M08_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M08_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M08_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M09_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M09_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M09_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M09_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M09_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M09_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M09_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M09_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M09_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M09_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M09_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M09_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M10_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M10_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M10_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M10_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M10_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M10_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M10_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M10_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M10_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M10_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M10_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M10_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M11_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M11_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M11_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M11_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M11_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M11_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M11_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M11_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M11_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M11_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M11_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M11_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M12_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M12_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M12_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M12_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M12_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M12_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M12_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M12_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M12_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M12_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M12_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M12_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M13_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M13_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M13_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M13_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M13_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M13_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M13_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M13_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M13_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M13_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M13_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M13_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M14_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M14_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M14_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M14_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M14_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M14_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M14_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M14_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M14_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M14_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M14_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M14_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M15_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M15_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M15_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M15_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M15_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M15_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M15_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M15_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M15_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M15_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M15_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M15_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M16_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M16_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M16_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M16_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M16_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M16_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M16_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M16_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M16_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M16_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M16_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M16_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M17_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M17_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M17_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M17_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M17_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M17_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M17_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M17_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M17_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M17_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M17_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M17_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M18_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M18_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M18_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M18_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M18_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M18_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M18_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M18_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M18_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M18_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M18_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M18_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M19_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M19_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M19_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M19_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M19_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M19_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M19_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M19_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M19_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M19_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M19_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M19_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M20_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M20_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M20_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M20_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M20_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M20_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M20_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M20_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M20_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M20_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M20_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M20_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M21_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M21_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M21_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M21_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M21_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M21_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M21_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M21_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M21_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M21_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M21_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M21_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M22_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M22_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M22_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M22_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M22_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M22_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M22_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M22_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M22_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M22_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M22_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M22_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M23_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M23_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M23_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M23_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M23_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M23_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M23_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M23_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M23_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M23_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M23_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M23_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M24_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M24_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M24_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M24_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M24_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M24_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M24_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M24_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M24_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M24_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M24_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M24_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M25_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M25_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M25_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M25_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M25_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M25_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M25_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M25_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M25_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M25_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M25_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M25_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M26_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M26_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M26_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M26_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M26_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M26_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M26_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M26_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M26_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M26_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M26_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M26_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M27_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M27_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M27_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M27_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M27_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M27_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M27_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M27_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M27_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M27_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M27_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M27_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 162
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.Unsafe.As[[System.Byte, System.Private.CoreLib],[System.UInt16, System.Private.CoreLib]](Byte ByRef)

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_InlineFieldReads()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,298
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,9E
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+1D0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rcx,[rdi+8]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       lea       rdi,[rcx+10]
       mov       ebx,[rcx+8]
M00_L01:
       xor       ebp,ebp
M00_L02:
       lea       rcx,[rsp+1C0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1D0]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.A, Benchmarks]](System.Span`1<Byte>, Benchmarks.A ByRef)
       lea       rcx,[rsp+1B0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1D4]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.B, Benchmarks]](System.Span`1<Byte>, Benchmarks.B ByRef)
       lea       rcx,[rsp+1A0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1D8]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.C, Benchmarks]](System.Span`1<Byte>, Benchmarks.C ByRef)
       lea       rcx,[rsp+190]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1E0]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.D, Benchmarks]](System.Span`1<Byte>, Benchmarks.D ByRef)
       lea       rcx,[rsp+180]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1E8]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.E, Benchmarks]](System.Span`1<Byte>, Benchmarks.E ByRef)
       lea       rcx,[rsp+170]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1F0]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.F, Benchmarks]](System.Span`1<Byte>, Benchmarks.F ByRef)
       lea       rcx,[rsp+160]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+1F8]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       lea       rcx,[rsp+150]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+200]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       lea       rcx,[rsp+140]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+208]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       lea       rcx,[rsp+130]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+210]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       lea       rcx,[rsp+120]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+218]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       lea       rcx,[rsp+110]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+220]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       lea       rcx,[rsp+100]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+228]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       lea       rcx,[rsp+0F0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+230]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       lea       rcx,[rsp+0E0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+238]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       lea       rcx,[rsp+0D0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+240]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       lea       rcx,[rsp+0C0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+248]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       lea       rcx,[rsp+0B0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+250]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       lea       rcx,[rsp+0A0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+258]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       lea       rcx,[rsp+90]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+260]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+268]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       lea       rcx,[rsp+70]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+270]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+278]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+280]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+288]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+290]
       call      Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       inc       ebp
       cmp       ebp,44521
       jl        near ptr M00_L02
       mov       rcx,rsi
       lea       rdx,[rsp+1D0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,298
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 1080
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.A, Benchmarks]](System.Span`1<Byte>, Benchmarks.A ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M01_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M01_L01
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M01_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 78
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.B, Benchmarks]](System.Span`1<Byte>, Benchmarks.B ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       cmp       edx,2
       jl        short M02_L00
       movzx     r9d,word ptr [rax]
       mov       [r8],r9w
       cmp       edx,2
       jb        short M02_L01
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M02_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M02_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 66
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.C, Benchmarks]](System.Span`1<Byte>, Benchmarks.C ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.C ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.D, Benchmarks]](System.Span`1<Byte>, Benchmarks.D ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.D ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.E, Benchmarks]](System.Span`1<Byte>, Benchmarks.E ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.E ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.F, Benchmarks]](System.Span`1<Byte>, Benchmarks.F ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.F ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.G ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.H ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.I ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.J ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.K ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.L ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.M ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.N ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.O ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.P ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Q ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.R ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.S ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.T ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.U ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.V ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.W ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.X ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Y ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       call      Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Z ByRef)
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.C ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M27_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M27_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M27_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M27_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M27_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M27_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M27_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M27_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M27_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M27_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M27_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M27_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.D ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M28_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M28_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M28_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M28_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M28_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M28_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M28_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M28_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M28_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M28_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M28_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M28_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.E ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M29_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M29_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M29_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M29_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M29_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M29_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M29_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M29_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M29_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M29_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M29_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M29_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.F ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M30_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M30_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M30_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M30_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M30_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M30_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M30_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M30_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M30_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M30_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M30_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M30_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.G ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M31_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M31_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M31_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M31_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M31_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M31_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M31_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M31_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M31_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M31_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M31_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M31_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.H ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M32_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M32_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M32_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M32_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M32_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M32_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M32_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M32_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M32_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M32_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M32_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M32_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.I ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M33_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M33_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M33_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M33_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M33_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M33_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M33_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M33_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M33_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M33_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M33_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M33_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.J ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M34_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M34_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M34_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M34_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M34_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M34_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M34_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M34_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M34_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M34_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M34_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M34_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.K ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M35_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M35_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M35_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M35_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M35_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M35_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M35_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M35_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M35_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M35_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M35_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M35_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.L ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M36_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M36_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M36_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M36_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M36_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M36_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M36_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M36_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M36_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M36_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M36_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M36_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.M ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M37_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M37_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M37_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M37_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M37_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M37_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M37_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M37_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M37_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M37_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M37_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M37_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.N ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M38_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M38_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M38_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M38_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M38_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M38_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M38_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M38_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M38_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M38_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M38_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M38_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.O ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M39_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M39_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M39_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M39_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M39_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M39_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M39_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M39_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M39_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M39_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M39_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M39_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.P ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M40_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M40_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M40_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M40_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M40_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M40_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M40_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M40_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M40_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M40_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M40_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M40_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Q ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M41_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M41_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M41_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M41_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M41_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M41_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M41_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M41_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M41_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M41_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M41_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M41_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.R ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M42_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M42_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M42_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M42_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M42_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M42_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M42_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M42_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M42_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M42_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M42_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M42_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.S ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M43_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M43_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M43_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M43_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M43_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M43_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M43_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M43_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M43_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M43_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M43_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M43_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.T ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M44_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M44_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M44_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M44_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M44_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M44_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M44_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M44_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M44_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M44_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M44_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M44_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.U ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M45_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M45_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M45_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M45_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M45_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M45_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M45_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M45_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M45_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M45_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M45_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M45_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.V ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M46_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M46_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M46_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M46_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M46_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M46_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M46_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M46_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M46_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M46_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M46_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M46_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.W ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M47_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M47_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M47_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M47_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M47_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M47_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M47_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M47_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M47_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M47_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M47_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M47_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.X ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M48_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M48_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M48_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M48_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M48_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M48_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M48_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M48_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M48_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M48_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M48_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M48_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Y ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M49_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M49_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M49_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M49_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M49_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M49_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M49_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M49_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M49_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M49_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M49_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M49_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Z ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r9d,r9d
       mov       [rsp+24],r9d
       cmp       edx,4
       jl        short M50_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M50_L01
       add       edx,0FFFFFFFC
       add       rax,4
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M50_L02
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M50_L03
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M50_L05
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M50_L04
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M50_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M50_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M50_L02:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M50_L03:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M50_L04:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M50_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_InlineStructReads()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,738
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,1C6
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+670]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rcx,[rdi+8]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       lea       rdi,[rcx+10]
       mov       ebx,[rcx+8]
M00_L01:
       xor       ebp,ebp
M00_L02:
       lea       rcx,[rsp+4C0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+670]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       mov       rcx,[rsp+4C0]
       mov       [rsp+660],rcx
       mov       ecx,[rsp+4C8]
       mov       [rsp+668],ecx
       lea       rcx,[rsp+4B0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+674]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       mov       rcx,[rsp+4B0]
       mov       [rsp+650],rcx
       mov       ecx,[rsp+4B8]
       mov       [rsp+658],ecx
       lea       rcx,[rsp+490]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+678]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+480]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+490]
       mov       [rdx],r8
       mov       r8d,[rsp+498]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+67C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+4A0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+480]
       mov       [rdx],r8
       mov       r8d,[rsp+488]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+67E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+4A0]
       mov       [rsp+640],rcx
       mov       ecx,[rsp+4A8]
       mov       [rsp+648],ecx
       lea       rcx,[rsp+460]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+680]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+450]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+460]
       mov       [rdx],r8
       mov       r8d,[rsp+468]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+684]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+470]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+450]
       mov       [rdx],r8
       mov       r8d,[rsp+458]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+686]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+470]
       mov       [rsp+630],rcx
       mov       ecx,[rsp+478]
       mov       [rsp+638],ecx
       lea       rcx,[rsp+430]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+688]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+420]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+430]
       mov       [rdx],r8
       mov       r8d,[rsp+438]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+68C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+440]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+420]
       mov       [rdx],r8
       mov       r8d,[rsp+428]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+68E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+440]
       mov       [rsp+620],rcx
       mov       ecx,[rsp+448]
       mov       [rsp+628],ecx
       lea       rcx,[rsp+400]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+690]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+3F0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+400]
       mov       [rdx],r8
       mov       r8d,[rsp+408]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+694]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+410]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+3F0]
       mov       [rdx],r8
       mov       r8d,[rsp+3F8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+696]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+410]
       mov       [rsp+610],rcx
       mov       ecx,[rsp+418]
       mov       [rsp+618],ecx
       lea       rcx,[rsp+3D0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+698]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+3C0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+3D0]
       mov       [rdx],r8
       mov       r8d,[rsp+3D8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+69C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+3E0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+3C0]
       mov       [rdx],r8
       mov       r8d,[rsp+3C8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+69E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+3E0]
       mov       [rsp+600],rcx
       mov       ecx,[rsp+3E8]
       mov       [rsp+608],ecx
       lea       rcx,[rsp+3A0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6A0]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+390]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+3A0]
       mov       [rdx],r8
       mov       r8d,[rsp+3A8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6A4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+3B0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+390]
       mov       [rdx],r8
       mov       r8d,[rsp+398]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6A6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+3B0]
       mov       [rsp+5F0],rcx
       mov       ecx,[rsp+3B8]
       mov       [rsp+5F8],ecx
       lea       rcx,[rsp+370]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6A8]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+360]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+370]
       mov       [rdx],r8
       mov       r8d,[rsp+378]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6AC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+380]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+360]
       mov       [rdx],r8
       mov       r8d,[rsp+368]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6AE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+380]
       mov       [rsp+5E0],rcx
       mov       ecx,[rsp+388]
       mov       [rsp+5E8],ecx
       lea       rcx,[rsp+340]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6B0]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+330]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+340]
       mov       [rdx],r8
       mov       r8d,[rsp+348]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6B4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+350]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+330]
       mov       [rdx],r8
       mov       r8d,[rsp+338]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6B6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+350]
       mov       [rsp+5D0],rcx
       mov       ecx,[rsp+358]
       mov       [rsp+5D8],ecx
       lea       rcx,[rsp+310]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6B8]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+300]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+310]
       mov       [rdx],r8
       mov       r8d,[rsp+318]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6BC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+320]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+300]
       mov       [rdx],r8
       mov       r8d,[rsp+308]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6BE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+320]
       mov       [rsp+5C0],rcx
       mov       ecx,[rsp+328]
       mov       [rsp+5C8],ecx
       lea       rcx,[rsp+2E0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6C0]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+2D0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+2E0]
       mov       [rdx],r8
       mov       r8d,[rsp+2E8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6C4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+2F0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+2D0]
       mov       [rdx],r8
       mov       r8d,[rsp+2D8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6C6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+2F0]
       mov       [rsp+5B0],rcx
       mov       ecx,[rsp+2F8]
       mov       [rsp+5B8],ecx
       lea       rcx,[rsp+2B0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6C8]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+2A0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+2B0]
       mov       [rdx],r8
       mov       r8d,[rsp+2B8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6CC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+2C0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+2A0]
       mov       [rdx],r8
       mov       r8d,[rsp+2A8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6CE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+2C0]
       mov       [rsp+5A0],rcx
       mov       ecx,[rsp+2C8]
       mov       [rsp+5A8],ecx
       lea       rcx,[rsp+280]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6D0]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+270]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+280]
       mov       [rdx],r8
       mov       r8d,[rsp+288]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6D4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+290]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+270]
       mov       [rdx],r8
       mov       r8d,[rsp+278]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6D6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+290]
       mov       [rsp+590],rcx
       mov       ecx,[rsp+298]
       mov       [rsp+598],ecx
       lea       rcx,[rsp+250]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6D8]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+240]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+250]
       mov       [rdx],r8
       mov       r8d,[rsp+258]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6DC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+260]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+240]
       mov       [rdx],r8
       mov       r8d,[rsp+248]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6DE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+260]
       mov       [rsp+580],rcx
       mov       ecx,[rsp+268]
       mov       [rsp+588],ecx
       lea       rcx,[rsp+220]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6E0]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+210]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+220]
       mov       [rdx],r8
       mov       r8d,[rsp+228]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6E4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+230]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+210]
       mov       [rdx],r8
       mov       r8d,[rsp+218]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6E6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+230]
       mov       [rsp+570],rcx
       mov       ecx,[rsp+238]
       mov       [rsp+578],ecx
       lea       rcx,[rsp+1F0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6E8]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+1E0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+1F0]
       mov       [rdx],r8
       mov       r8d,[rsp+1F8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6EC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+200]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+1E0]
       mov       [rdx],r8
       mov       r8d,[rsp+1E8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6EE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+200]
       mov       [rsp+560],rcx
       mov       ecx,[rsp+208]
       mov       [rsp+568],ecx
       lea       rcx,[rsp+1C0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6F0]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+1B0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+1C0]
       mov       [rdx],r8
       mov       r8d,[rsp+1C8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6F4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+1D0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+1B0]
       mov       [rdx],r8
       mov       r8d,[rsp+1B8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6F6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+1D0]
       mov       [rsp+550],rcx
       mov       ecx,[rsp+1D8]
       mov       [rsp+558],ecx
       lea       rcx,[rsp+190]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6F8]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+180]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+190]
       mov       [rdx],r8
       mov       r8d,[rsp+198]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6FC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+1A0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+180]
       mov       [rdx],r8
       mov       r8d,[rsp+188]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+6FE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+1A0]
       mov       [rsp+540],rcx
       mov       ecx,[rsp+1A8]
       mov       [rsp+548],ecx
       lea       rcx,[rsp+160]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+700]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+150]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+160]
       mov       [rdx],r8
       mov       r8d,[rsp+168]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+704]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+170]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+150]
       mov       [rdx],r8
       mov       r8d,[rsp+158]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+706]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+170]
       mov       [rsp+530],rcx
       mov       ecx,[rsp+178]
       mov       [rsp+538],ecx
       lea       rcx,[rsp+130]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+708]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+120]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+130]
       mov       [rdx],r8
       mov       r8d,[rsp+138]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+70C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+140]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+120]
       mov       [rdx],r8
       mov       r8d,[rsp+128]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+70E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+140]
       mov       [rsp+520],rcx
       mov       ecx,[rsp+148]
       mov       [rsp+528],ecx
       lea       rcx,[rsp+100]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+710]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+0F0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+100]
       mov       [rdx],r8
       mov       r8d,[rsp+108]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+714]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+110]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+0F0]
       mov       [rdx],r8
       mov       r8d,[rsp+0F8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+716]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+110]
       mov       [rsp+510],rcx
       mov       ecx,[rsp+118]
       mov       [rsp+518],ecx
       lea       rcx,[rsp+0D0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+718]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+0C0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+0D0]
       mov       [rdx],r8
       mov       r8d,[rsp+0D8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+71C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+0E0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+0C0]
       mov       [rdx],r8
       mov       r8d,[rsp+0C8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+71E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+0E0]
       mov       [rsp+500],rcx
       mov       ecx,[rsp+0E8]
       mov       [rsp+508],ecx
       lea       rcx,[rsp+0A0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+720]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+90]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+0A0]
       mov       [rdx],r8
       mov       r8d,[rsp+0A8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+724]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+0B0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+90]
       mov       [rdx],r8
       mov       r8d,[rsp+98]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+726]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+0B0]
       mov       [rsp+4F0],rcx
       mov       ecx,[rsp+0B8]
       mov       [rsp+4F8],ecx
       lea       rcx,[rsp+70]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+728]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+70]
       mov       [rdx],r8
       mov       r8d,[rsp+78]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+72C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+60]
       mov       [rdx],r8
       mov       r8d,[rsp+68]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+72E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rcx,[rsp+80]
       mov       [rsp+4E0],rcx
       mov       ecx,[rsp+88]
       mov       [rsp+4E8],ecx
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+730]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+40]
       mov       [rdx],r8
       mov       r8d,[rsp+48]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+734]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+30]
       mov       [rdx],r8
       mov       r8d,[rsp+38]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+736]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       mov       rdx,[rsp+50]
       mov       [rsp+4D0],rdx
       mov       edx,[rsp+58]
       mov       [rsp+4D8],edx
       inc       ebp
       cmp       ebp,44521
       jl        near ptr M00_L02
       mov       rcx,rsi
       lea       rdx,[rsp+670]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,738
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 4422
```
```assembly
; Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+24],eax
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       cmp       edx,4
       jl        short M01_L00
       mov       r9d,[rax]
       mov       [r8],r9d
       cmp       edx,4
       jb        short M01_L01
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M01_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M01_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 70
```
```assembly
; Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       cmp       edx,2
       jl        short M02_L00
       movzx     r9d,word ptr [rax]
       mov       [r8],r9w
       cmp       edx,2
       jb        short M02_L01
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M02_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M02_L01:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 66
```
```assembly
; Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       cmp       edx,0
       jbe       short M03_L01
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M03_L00
       dec       edx
       inc       rax
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M03_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M03_L01:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 58
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_ManualFieldForField_Progressive()
       push      rdi
       push      rsi
       test      rax,[rsp+0F000]
       sub       rsp,10D8
       vzeroupper
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,42E
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+1010]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rax,[rdi+8]
       lea       rdx,[rsp+0CC0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       test      rax,rax
       jne       short M00_L00
       lea       rax,[rsp+0CC0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       jmp       short M00_L01
M00_L00:
       lea       rdx,[rax+10]
       mov       [rsp+0CB8],rdx
       mov       rdx,[rsp+0CB8]
       lea       rcx,[rsp+0CC0]
       mov       [rcx],rdx
       mov       eax,[rax+8]
       mov       [rsp+0CC8],eax
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+0CC0]
       vmovdqu   xmmword ptr [rsp+1000],xmm0
       xor       edi,edi
M00_L02:
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+0CA8],xmm0
       lea       rax,[rsp+0C98]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+0CA8]
       mov       edx,[rsp+0CB0]
       mov       [rsp+0C90],rax
       mov       rax,[rsp+0C90]
       lea       rcx,[rsp+0C98]
       mov       [rcx],rax
       mov       [rsp+0CA0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0C98]
       vmovdqu   xmmword ptr [rsp+0FE0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FE0]
       vmovdqu   xmmword ptr [rsp+0C80],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+0C70],xmm0
       cmp       dword ptr [rsp+0C78],4
       jl        near ptr M00_L04
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       mov       rax,[rsp+0C60]
       mov       eax,[rax]
       mov       [rsp+1010],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+0C50],xmm0
       lea       rax,[rsp+0C40]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+0C50]
       mov       edx,[rsp+0C58]
       mov       [rsp+0C38],rax
       mov       rax,[rsp+0C38]
       lea       rcx,[rsp+0C40]
       mov       [rcx],rax
       mov       [rsp+0C48],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0C40]
       vmovdqu   xmmword ptr [rsp+0FD0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FD0]
       vmovdqu   xmmword ptr [rsp+0C28],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C28]
       vmovdqu   xmmword ptr [rsp+0C18],xmm0
       cmp       dword ptr [rsp+0C20],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+0C18]
       vmovdqu   xmmword ptr [rsp+0C08],xmm0
       mov       rax,[rsp+0C08]
       movzx     eax,word ptr [rax]
       mov       [rsp+1014],ax
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+0BF8],xmm0
       lea       rax,[rsp+0BE8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+0BF8]
       mov       edx,[rsp+0C00]
       mov       [rsp+0BE0],rax
       mov       rax,[rsp+0BE0]
       lea       rcx,[rsp+0BE8]
       mov       [rcx],rax
       mov       [rsp+0BF0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0BE8]
       vmovdqu   xmmword ptr [rsp+0FC0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FC0]
       vmovdqu   xmmword ptr [rsp+0BD0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0BD0]
       vmovdqu   xmmword ptr [rsp+0BC0],xmm0
       cmp       dword ptr [rsp+0BC8],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+0BC0]
       vmovdqu   xmmword ptr [rsp+0BB0],xmm0
       mov       rax,[rsp+0BB0]
       mov       eax,[rax]
       mov       [rsp+1018],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L07
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+0BA0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+0B98],rax
       mov       rax,[rsp+0B98]
       lea       rcx,[rsp+0BA0]
       mov       [rcx],rax
       mov       [rsp+0BA8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0BA0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+0B88],xmm0
       lea       rax,[rsp+0B78]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+0B88]
       mov       edx,[rsp+0B90]
       mov       [rsp+0B70],rax
       mov       rax,[rsp+0B70]
       lea       rcx,[rsp+0B78]
       mov       [rcx],rax
       mov       [rsp+0B80],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0B78]
       vmovdqu   xmmword ptr [rsp+0FB0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FB0]
       vmovdqu   xmmword ptr [rsp+0B60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B60]
       vmovdqu   xmmword ptr [rsp+0B50],xmm0
       cmp       dword ptr [rsp+0B58],2
       jl        near ptr M00_L08
       vmovdqu   xmm0,xmmword ptr [rsp+0B50]
       vmovdqu   xmmword ptr [rsp+0B40],xmm0
       mov       rax,[rsp+0B40]
       movzx     eax,word ptr [rax]
       mov       [rsp+101C],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L09
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+0B30]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+0B28],rax
       mov       rax,[rsp+0B28]
       lea       rcx,[rsp+0B30]
       mov       [rcx],rax
       mov       [rsp+0B38],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0B30]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+101E],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+0B18],xmm0
       lea       rax,[rsp+0B08]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+0B18]
       mov       edx,[rsp+0B20]
       mov       [rsp+0B00],rax
       mov       rax,[rsp+0B00]
       lea       rcx,[rsp+0B08]
       mov       [rcx],rax
       mov       [rsp+0B10],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0B08]
       vmovdqu   xmmword ptr [rsp+0FA0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FA0]
       vmovdqu   xmmword ptr [rsp+0AF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0AF0]
       vmovdqu   xmmword ptr [rsp+0AE0],xmm0
       cmp       dword ptr [rsp+0AE8],4
       jl        near ptr M00_L10
       vmovdqu   xmm0,xmmword ptr [rsp+0AE0]
       vmovdqu   xmmword ptr [rsp+0AD0],xmm0
       mov       rax,[rsp+0AD0]
       mov       eax,[rax]
       mov       [rsp+1020],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L11
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+0AC0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+0AB8],rax
       mov       rax,[rsp+0AB8]
       lea       rcx,[rsp+0AC0]
       mov       [rcx],rax
       mov       [rsp+0AC8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0AC0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+0AA8],xmm0
       lea       rax,[rsp+0A98]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+0AA8]
       mov       edx,[rsp+0AB0]
       mov       [rsp+0A90],rax
       mov       rax,[rsp+0A90]
       lea       rcx,[rsp+0A98]
       mov       [rcx],rax
       mov       [rsp+0AA0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0A98]
       vmovdqu   xmmword ptr [rsp+0F90],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F90]
       vmovdqu   xmmword ptr [rsp+0A80],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A80]
       vmovdqu   xmmword ptr [rsp+0A70],xmm0
       cmp       dword ptr [rsp+0A78],2
       jl        near ptr M00_L12
       vmovdqu   xmm0,xmmword ptr [rsp+0A70]
       vmovdqu   xmmword ptr [rsp+0A60],xmm0
       mov       rax,[rsp+0A60]
       movzx     eax,word ptr [rax]
       mov       [rsp+1024],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L13
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+0A50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+0A48],rax
       mov       rax,[rsp+0A48]
       lea       rcx,[rsp+0A50]
       mov       [rcx],rax
       mov       [rsp+0A58],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0A50]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+1026],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+0A38],xmm0
       lea       rax,[rsp+0A28]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+0A38]
       mov       edx,[rsp+0A40]
       mov       [rsp+0A20],rax
       mov       rax,[rsp+0A20]
       lea       rcx,[rsp+0A28]
       mov       [rcx],rax
       mov       [rsp+0A30],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0A28]
       vmovdqu   xmmword ptr [rsp+0F80],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F80]
       vmovdqu   xmmword ptr [rsp+0A10],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A10]
       vmovdqu   xmmword ptr [rsp+0A00],xmm0
       cmp       dword ptr [rsp+0A08],4
       jl        near ptr M00_L14
       vmovdqu   xmm0,xmmword ptr [rsp+0A00]
       vmovdqu   xmmword ptr [rsp+9F0],xmm0
       mov       rax,[rsp+9F0]
       mov       eax,[rax]
       mov       [rsp+1028],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L15
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+9E0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+9D8],rax
       mov       rax,[rsp+9D8]
       lea       rcx,[rsp+9E0]
       mov       [rcx],rax
       mov       [rsp+9E8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+9E0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+9C8],xmm0
       lea       rax,[rsp+9B8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+9C8]
       mov       edx,[rsp+9D0]
       mov       [rsp+9B0],rax
       mov       rax,[rsp+9B0]
       lea       rcx,[rsp+9B8]
       mov       [rcx],rax
       mov       [rsp+9C0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+9B8]
       vmovdqu   xmmword ptr [rsp+0F70],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F70]
       vmovdqu   xmmword ptr [rsp+9A0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+9A0]
       vmovdqu   xmmword ptr [rsp+990],xmm0
       cmp       dword ptr [rsp+998],2
       jl        near ptr M00_L16
       vmovdqu   xmm0,xmmword ptr [rsp+990]
       vmovdqu   xmmword ptr [rsp+980],xmm0
       mov       rax,[rsp+980]
       movzx     eax,word ptr [rax]
       mov       [rsp+102C],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L17
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+970]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+968],rax
       mov       rax,[rsp+968]
       lea       rcx,[rsp+970]
       mov       [rcx],rax
       mov       [rsp+978],edx
       vmovdqu   xmm0,xmmword ptr [rsp+970]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+102E],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+958],xmm0
       lea       rax,[rsp+948]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+958]
       mov       edx,[rsp+960]
       mov       [rsp+940],rax
       mov       rax,[rsp+940]
       lea       rcx,[rsp+948]
       mov       [rcx],rax
       mov       [rsp+950],edx
       vmovdqu   xmm0,xmmword ptr [rsp+948]
       vmovdqu   xmmword ptr [rsp+0F60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F60]
       vmovdqu   xmmword ptr [rsp+930],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+930]
       vmovdqu   xmmword ptr [rsp+920],xmm0
       cmp       dword ptr [rsp+928],4
       jl        near ptr M00_L18
       vmovdqu   xmm0,xmmword ptr [rsp+920]
       vmovdqu   xmmword ptr [rsp+910],xmm0
       mov       rax,[rsp+910]
       mov       eax,[rax]
       mov       [rsp+1030],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L19
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+900]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+8F8],rax
       mov       rax,[rsp+8F8]
       lea       rcx,[rsp+900]
       mov       [rcx],rax
       mov       [rsp+908],edx
       vmovdqu   xmm0,xmmword ptr [rsp+900]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+8E8],xmm0
       lea       rax,[rsp+8D8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+8E8]
       mov       edx,[rsp+8F0]
       mov       [rsp+8D0],rax
       mov       rax,[rsp+8D0]
       lea       rcx,[rsp+8D8]
       mov       [rcx],rax
       mov       [rsp+8E0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+8D8]
       vmovdqu   xmmword ptr [rsp+0F50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F50]
       vmovdqu   xmmword ptr [rsp+8C0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+8C0]
       vmovdqu   xmmword ptr [rsp+8B0],xmm0
       cmp       dword ptr [rsp+8B8],2
       jl        near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rsp+8B0]
       vmovdqu   xmmword ptr [rsp+8A0],xmm0
       mov       rax,[rsp+8A0]
       movzx     eax,word ptr [rax]
       mov       [rsp+1034],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L21
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+890]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+888],rax
       mov       rax,[rsp+888]
       lea       rcx,[rsp+890]
       mov       [rcx],rax
       mov       [rsp+898],edx
       vmovdqu   xmm0,xmmword ptr [rsp+890]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+1036],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+878],xmm0
       lea       rax,[rsp+868]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+878]
       mov       edx,[rsp+880]
       mov       [rsp+860],rax
       mov       rax,[rsp+860]
       lea       rcx,[rsp+868]
       mov       [rcx],rax
       mov       [rsp+870],edx
       vmovdqu   xmm0,xmmword ptr [rsp+868]
       vmovdqu   xmmword ptr [rsp+0F40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F40]
       vmovdqu   xmmword ptr [rsp+850],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+850]
       vmovdqu   xmmword ptr [rsp+840],xmm0
       cmp       dword ptr [rsp+848],4
       jl        near ptr M00_L22
       vmovdqu   xmm0,xmmword ptr [rsp+840]
       vmovdqu   xmmword ptr [rsp+830],xmm0
       mov       rax,[rsp+830]
       mov       eax,[rax]
       mov       [rsp+1038],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L23
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+820]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+818],rax
       mov       rax,[rsp+818]
       lea       rcx,[rsp+820]
       mov       [rcx],rax
       mov       [rsp+828],edx
       vmovdqu   xmm0,xmmword ptr [rsp+820]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+808],xmm0
       lea       rax,[rsp+7F8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+808]
       mov       edx,[rsp+810]
       mov       [rsp+7F0],rax
       mov       rax,[rsp+7F0]
       lea       rcx,[rsp+7F8]
       mov       [rcx],rax
       mov       [rsp+800],edx
       vmovdqu   xmm0,xmmword ptr [rsp+7F8]
       vmovdqu   xmmword ptr [rsp+0F30],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F30]
       vmovdqu   xmmword ptr [rsp+7E0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+7E0]
       vmovdqu   xmmword ptr [rsp+7D0],xmm0
       cmp       dword ptr [rsp+7D8],2
       jl        near ptr M00_L24
       vmovdqu   xmm0,xmmword ptr [rsp+7D0]
       vmovdqu   xmmword ptr [rsp+7C0],xmm0
       mov       rax,[rsp+7C0]
       movzx     eax,word ptr [rax]
       mov       [rsp+103C],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L25
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+7B0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+7A8],rax
       mov       rax,[rsp+7A8]
       lea       rcx,[rsp+7B0]
       mov       [rcx],rax
       mov       [rsp+7B8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+7B0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+103E],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+798],xmm0
       lea       rax,[rsp+788]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+798]
       mov       edx,[rsp+7A0]
       mov       [rsp+780],rax
       mov       rax,[rsp+780]
       lea       rcx,[rsp+788]
       mov       [rcx],rax
       mov       [rsp+790],edx
       vmovdqu   xmm0,xmmword ptr [rsp+788]
       vmovdqu   xmmword ptr [rsp+0F20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F20]
       vmovdqu   xmmword ptr [rsp+770],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+770]
       vmovdqu   xmmword ptr [rsp+760],xmm0
       cmp       dword ptr [rsp+768],4
       jl        near ptr M00_L26
       vmovdqu   xmm0,xmmword ptr [rsp+760]
       vmovdqu   xmmword ptr [rsp+750],xmm0
       mov       rax,[rsp+750]
       mov       eax,[rax]
       mov       [rsp+1040],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L27
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+740]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+738],rax
       mov       rax,[rsp+738]
       lea       rcx,[rsp+740]
       mov       [rcx],rax
       mov       [rsp+748],edx
       vmovdqu   xmm0,xmmword ptr [rsp+740]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+728],xmm0
       lea       rax,[rsp+718]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+728]
       mov       edx,[rsp+730]
       mov       [rsp+710],rax
       mov       rax,[rsp+710]
       lea       rcx,[rsp+718]
       mov       [rcx],rax
       mov       [rsp+720],edx
       vmovdqu   xmm0,xmmword ptr [rsp+718]
       vmovdqu   xmmword ptr [rsp+0F10],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F10]
       vmovdqu   xmmword ptr [rsp+700],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+700]
       vmovdqu   xmmword ptr [rsp+6F0],xmm0
       cmp       dword ptr [rsp+6F8],2
       jl        near ptr M00_L28
       vmovdqu   xmm0,xmmword ptr [rsp+6F0]
       vmovdqu   xmmword ptr [rsp+6E0],xmm0
       mov       rax,[rsp+6E0]
       movzx     eax,word ptr [rax]
       mov       [rsp+1044],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L29
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+6D0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+6C8],rax
       mov       rax,[rsp+6C8]
       lea       rcx,[rsp+6D0]
       mov       [rcx],rax
       mov       [rsp+6D8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+6D0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+1046],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+6B8],xmm0
       lea       rax,[rsp+6A8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+6B8]
       mov       edx,[rsp+6C0]
       mov       [rsp+6A0],rax
       mov       rax,[rsp+6A0]
       lea       rcx,[rsp+6A8]
       mov       [rcx],rax
       mov       [rsp+6B0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+6A8]
       vmovdqu   xmmword ptr [rsp+0F00],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F00]
       vmovdqu   xmmword ptr [rsp+690],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+690]
       vmovdqu   xmmword ptr [rsp+680],xmm0
       cmp       dword ptr [rsp+688],4
       jl        near ptr M00_L30
       vmovdqu   xmm0,xmmword ptr [rsp+680]
       vmovdqu   xmmword ptr [rsp+670],xmm0
       mov       rax,[rsp+670]
       mov       eax,[rax]
       mov       [rsp+1048],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L31
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+660]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+658],rax
       mov       rax,[rsp+658]
       lea       rcx,[rsp+660]
       mov       [rcx],rax
       mov       [rsp+668],edx
       vmovdqu   xmm0,xmmword ptr [rsp+660]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+648],xmm0
       lea       rax,[rsp+638]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+648]
       mov       edx,[rsp+650]
       mov       [rsp+630],rax
       mov       rax,[rsp+630]
       lea       rcx,[rsp+638]
       mov       [rcx],rax
       mov       [rsp+640],edx
       vmovdqu   xmm0,xmmword ptr [rsp+638]
       vmovdqu   xmmword ptr [rsp+0EF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EF0]
       vmovdqu   xmmword ptr [rsp+620],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+620]
       vmovdqu   xmmword ptr [rsp+610],xmm0
       cmp       dword ptr [rsp+618],2
       jl        near ptr M00_L32
       vmovdqu   xmm0,xmmword ptr [rsp+610]
       vmovdqu   xmmword ptr [rsp+600],xmm0
       mov       rax,[rsp+600]
       movzx     eax,word ptr [rax]
       mov       [rsp+104C],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L33
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+5F0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+5E8],rax
       mov       rax,[rsp+5E8]
       lea       rcx,[rsp+5F0]
       mov       [rcx],rax
       mov       [rsp+5F8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+5F0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+104E],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+5D8],xmm0
       lea       rax,[rsp+5C8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+5D8]
       mov       edx,[rsp+5E0]
       mov       [rsp+5C0],rax
       mov       rax,[rsp+5C0]
       lea       rcx,[rsp+5C8]
       mov       [rcx],rax
       mov       [rsp+5D0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+5C8]
       vmovdqu   xmmword ptr [rsp+0EE0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EE0]
       vmovdqu   xmmword ptr [rsp+5B0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+5B0]
       vmovdqu   xmmword ptr [rsp+5A0],xmm0
       cmp       dword ptr [rsp+5A8],4
       jl        near ptr M00_L34
       vmovdqu   xmm0,xmmword ptr [rsp+5A0]
       vmovdqu   xmmword ptr [rsp+590],xmm0
       mov       rax,[rsp+590]
       mov       eax,[rax]
       mov       [rsp+1050],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L35
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+580]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+578],rax
       mov       rax,[rsp+578]
       lea       rcx,[rsp+580]
       mov       [rcx],rax
       mov       [rsp+588],edx
       vmovdqu   xmm0,xmmword ptr [rsp+580]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+568],xmm0
       lea       rax,[rsp+558]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+568]
       mov       edx,[rsp+570]
       mov       [rsp+550],rax
       mov       rax,[rsp+550]
       lea       rcx,[rsp+558]
       mov       [rcx],rax
       mov       [rsp+560],edx
       vmovdqu   xmm0,xmmword ptr [rsp+558]
       vmovdqu   xmmword ptr [rsp+0ED0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0ED0]
       vmovdqu   xmmword ptr [rsp+540],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+540]
       vmovdqu   xmmword ptr [rsp+530],xmm0
       cmp       dword ptr [rsp+538],2
       jl        near ptr M00_L36
       vmovdqu   xmm0,xmmword ptr [rsp+530]
       vmovdqu   xmmword ptr [rsp+520],xmm0
       mov       rax,[rsp+520]
       movzx     eax,word ptr [rax]
       mov       [rsp+1054],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L37
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+510]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+508],rax
       mov       rax,[rsp+508]
       lea       rcx,[rsp+510]
       mov       [rcx],rax
       mov       [rsp+518],edx
       vmovdqu   xmm0,xmmword ptr [rsp+510]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+1056],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+4F8],xmm0
       lea       rax,[rsp+4E8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+4F8]
       mov       edx,[rsp+500]
       mov       [rsp+4E0],rax
       mov       rax,[rsp+4E0]
       lea       rcx,[rsp+4E8]
       mov       [rcx],rax
       mov       [rsp+4F0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+4E8]
       vmovdqu   xmmword ptr [rsp+0EC0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EC0]
       vmovdqu   xmmword ptr [rsp+4D0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+4D0]
       vmovdqu   xmmword ptr [rsp+4C0],xmm0
       cmp       dword ptr [rsp+4C8],4
       jl        near ptr M00_L38
       vmovdqu   xmm0,xmmword ptr [rsp+4C0]
       vmovdqu   xmmword ptr [rsp+4B0],xmm0
       mov       rax,[rsp+4B0]
       mov       eax,[rax]
       mov       [rsp+1058],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L39
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+4A0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+498],rax
       mov       rax,[rsp+498]
       lea       rcx,[rsp+4A0]
       mov       [rcx],rax
       mov       [rsp+4A8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+4A0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+488],xmm0
       lea       rax,[rsp+478]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+488]
       mov       edx,[rsp+490]
       mov       [rsp+470],rax
       mov       rax,[rsp+470]
       lea       rcx,[rsp+478]
       mov       [rcx],rax
       mov       [rsp+480],edx
       vmovdqu   xmm0,xmmword ptr [rsp+478]
       vmovdqu   xmmword ptr [rsp+0EB0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EB0]
       vmovdqu   xmmword ptr [rsp+460],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+460]
       vmovdqu   xmmword ptr [rsp+450],xmm0
       cmp       dword ptr [rsp+458],2
       jl        near ptr M00_L40
       vmovdqu   xmm0,xmmword ptr [rsp+450]
       vmovdqu   xmmword ptr [rsp+440],xmm0
       mov       rax,[rsp+440]
       movzx     eax,word ptr [rax]
       mov       [rsp+105C],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L41
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+430]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+428],rax
       mov       rax,[rsp+428]
       lea       rcx,[rsp+430]
       mov       [rcx],rax
       mov       [rsp+438],edx
       vmovdqu   xmm0,xmmword ptr [rsp+430]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+105E],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+418],xmm0
       lea       rax,[rsp+408]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+418]
       mov       edx,[rsp+420]
       mov       [rsp+400],rax
       mov       rax,[rsp+400]
       lea       rcx,[rsp+408]
       mov       [rcx],rax
       mov       [rsp+410],edx
       vmovdqu   xmm0,xmmword ptr [rsp+408]
       vmovdqu   xmmword ptr [rsp+0EA0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EA0]
       vmovdqu   xmmword ptr [rsp+3F0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+3F0]
       vmovdqu   xmmword ptr [rsp+3E0],xmm0
       cmp       dword ptr [rsp+3E8],4
       jl        near ptr M00_L42
       vmovdqu   xmm0,xmmword ptr [rsp+3E0]
       vmovdqu   xmmword ptr [rsp+3D0],xmm0
       mov       rax,[rsp+3D0]
       mov       eax,[rax]
       mov       [rsp+1060],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L43
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+3C0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+3B8],rax
       mov       rax,[rsp+3B8]
       lea       rcx,[rsp+3C0]
       mov       [rcx],rax
       mov       [rsp+3C8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+3C0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+3A8],xmm0
       lea       rax,[rsp+398]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+3A8]
       mov       edx,[rsp+3B0]
       mov       [rsp+390],rax
       mov       rax,[rsp+390]
       lea       rcx,[rsp+398]
       mov       [rcx],rax
       mov       [rsp+3A0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+398]
       vmovdqu   xmmword ptr [rsp+0E90],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E90]
       vmovdqu   xmmword ptr [rsp+380],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+380]
       vmovdqu   xmmword ptr [rsp+370],xmm0
       cmp       dword ptr [rsp+378],2
       jl        near ptr M00_L44
       vmovdqu   xmm0,xmmword ptr [rsp+370]
       vmovdqu   xmmword ptr [rsp+360],xmm0
       mov       rax,[rsp+360]
       movzx     eax,word ptr [rax]
       mov       [rsp+1064],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L45
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+350]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+348],rax
       mov       rax,[rsp+348]
       lea       rcx,[rsp+350]
       mov       [rcx],rax
       mov       [rsp+358],edx
       vmovdqu   xmm0,xmmword ptr [rsp+350]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+1066],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+338],xmm0
       lea       rax,[rsp+328]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+338]
       mov       edx,[rsp+340]
       mov       [rsp+320],rax
       mov       rax,[rsp+320]
       lea       rcx,[rsp+328]
       mov       [rcx],rax
       mov       [rsp+330],edx
       vmovdqu   xmm0,xmmword ptr [rsp+328]
       vmovdqu   xmmword ptr [rsp+0E80],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E80]
       vmovdqu   xmmword ptr [rsp+310],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+310]
       vmovdqu   xmmword ptr [rsp+300],xmm0
       cmp       dword ptr [rsp+308],4
       jl        near ptr M00_L46
       vmovdqu   xmm0,xmmword ptr [rsp+300]
       vmovdqu   xmmword ptr [rsp+2F0],xmm0
       mov       rax,[rsp+2F0]
       mov       eax,[rax]
       mov       [rsp+1068],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L47
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+2E0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+2D8],rax
       mov       rax,[rsp+2D8]
       lea       rcx,[rsp+2E0]
       mov       [rcx],rax
       mov       [rsp+2E8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+2E0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+2C8],xmm0
       lea       rax,[rsp+2B8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+2C8]
       mov       edx,[rsp+2D0]
       mov       [rsp+2B0],rax
       mov       rax,[rsp+2B0]
       lea       rcx,[rsp+2B8]
       mov       [rcx],rax
       mov       [rsp+2C0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+2B8]
       vmovdqu   xmmword ptr [rsp+0E70],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E70]
       vmovdqu   xmmword ptr [rsp+2A0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+2A0]
       vmovdqu   xmmword ptr [rsp+290],xmm0
       cmp       dword ptr [rsp+298],2
       jl        near ptr M00_L48
       vmovdqu   xmm0,xmmword ptr [rsp+290]
       vmovdqu   xmmword ptr [rsp+280],xmm0
       mov       rax,[rsp+280]
       movzx     eax,word ptr [rax]
       mov       [rsp+106C],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L49
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+270]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+268],rax
       mov       rax,[rsp+268]
       lea       rcx,[rsp+270]
       mov       [rcx],rax
       mov       [rsp+278],edx
       vmovdqu   xmm0,xmmword ptr [rsp+270]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+106E],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+258],xmm0
       lea       rax,[rsp+248]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+258]
       mov       edx,[rsp+260]
       mov       [rsp+240],rax
       mov       rax,[rsp+240]
       lea       rcx,[rsp+248]
       mov       [rcx],rax
       mov       [rsp+250],edx
       vmovdqu   xmm0,xmmword ptr [rsp+248]
       vmovdqu   xmmword ptr [rsp+0E60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E60]
       vmovdqu   xmmword ptr [rsp+230],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+230]
       vmovdqu   xmmword ptr [rsp+220],xmm0
       cmp       dword ptr [rsp+228],4
       jl        near ptr M00_L50
       vmovdqu   xmm0,xmmword ptr [rsp+220]
       vmovdqu   xmmword ptr [rsp+210],xmm0
       mov       rax,[rsp+210]
       mov       eax,[rax]
       mov       [rsp+1070],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L51
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+200]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+1F8],rax
       mov       rax,[rsp+1F8]
       lea       rcx,[rsp+200]
       mov       [rcx],rax
       mov       [rsp+208],edx
       vmovdqu   xmm0,xmmword ptr [rsp+200]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+1E8],xmm0
       lea       rax,[rsp+1D8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+1E8]
       mov       edx,[rsp+1F0]
       mov       [rsp+1D0],rax
       mov       rax,[rsp+1D0]
       lea       rcx,[rsp+1D8]
       mov       [rcx],rax
       mov       [rsp+1E0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+1D8]
       vmovdqu   xmmword ptr [rsp+0E50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E50]
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1C0]
       vmovdqu   xmmword ptr [rsp+1B0],xmm0
       cmp       dword ptr [rsp+1B8],2
       jl        near ptr M00_L52
       vmovdqu   xmm0,xmmword ptr [rsp+1B0]
       vmovdqu   xmmword ptr [rsp+1A0],xmm0
       mov       rax,[rsp+1A0]
       movzx     eax,word ptr [rax]
       mov       [rsp+1074],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L53
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+190]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+188],rax
       mov       rax,[rsp+188]
       lea       rcx,[rsp+190]
       mov       [rcx],rax
       mov       [rsp+198],edx
       vmovdqu   xmm0,xmmword ptr [rsp+190]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+1076],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+178],xmm0
       lea       rax,[rsp+168]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+178]
       mov       edx,[rsp+180]
       mov       [rsp+160],rax
       mov       rax,[rsp+160]
       lea       rcx,[rsp+168]
       mov       [rcx],rax
       mov       [rsp+170],edx
       vmovdqu   xmm0,xmmword ptr [rsp+168]
       vmovdqu   xmmword ptr [rsp+0E40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E40]
       vmovdqu   xmmword ptr [rsp+150],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+150]
       vmovdqu   xmmword ptr [rsp+140],xmm0
       cmp       dword ptr [rsp+148],4
       jl        near ptr M00_L54
       vmovdqu   xmm0,xmmword ptr [rsp+140]
       vmovdqu   xmmword ptr [rsp+130],xmm0
       mov       rax,[rsp+130]
       mov       eax,[rax]
       mov       [rsp+1078],eax
       cmp       dword ptr [rsp+0FF8],4
       jb        near ptr M00_L55
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+120]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFC
       add       rax,4
       mov       [rsp+118],rax
       mov       rax,[rsp+118]
       lea       rcx,[rsp+120]
       mov       [rcx],rax
       mov       [rsp+128],edx
       vmovdqu   xmm0,xmmword ptr [rsp+120]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       lea       rax,[rsp+0F8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+108]
       mov       edx,[rsp+110]
       mov       [rsp+0F0],rax
       mov       rax,[rsp+0F0]
       lea       rcx,[rsp+0F8]
       mov       [rcx],rax
       mov       [rsp+100],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0F8]
       vmovdqu   xmmword ptr [rsp+0E30],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E30]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E0]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       cmp       dword ptr [rsp+0D8],2
       jl        near ptr M00_L56
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rax,[rsp+0C0]
       movzx     eax,word ptr [rax]
       mov       [rsp+107C],ax
       cmp       dword ptr [rsp+0FF8],2
       jb        near ptr M00_L57
       mov       rax,[rsp+0FF0]
       lea       rdx,[rsp+0B0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rdx],xmm0
       mov       edx,[rsp+0FF8]
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rsp+0A8],rax
       mov       rax,[rsp+0A8]
       lea       rcx,[rsp+0B0]
       mov       [rcx],rax
       mov       [rsp+0B8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rax,[rsp+0FF0]
       movzx     eax,byte ptr [rax]
       mov       [rsp+107E],al
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       lea       rax,[rsp+88]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       rax,[rsp+98]
       mov       edx,[rsp+0A0]
       mov       [rsp+80],rax
       mov       rax,[rsp+80]
       lea       rcx,[rsp+88]
       mov       [rcx],rax
       mov       [rsp+90],edx
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+0E20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E20]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       cmp       dword ptr [rsp+68],4
       jl        near ptr M00_L58
       vmovdqu   xmm0,xmmword ptr [rsp+60]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rax,[rsp+50]
       mov       eax,[rax]
       mov       [rsp+1080],eax
       cmp       dword ptr [rsp+0FF8],4
       jae       short M00_L03
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
M00_L03:
       lea       rcx,[rsp+40]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+0FF0]
       mov       edx,4
       call      Internal.Runtime.CompilerServices.Unsafe.Add[[System.Byte, System.Private.CoreLib]](Byte ByRef, Int32)
       mov       rdx,rax
       mov       r8d,[rsp+0FF8]
       add       r8d,0FFFFFFFC
       lea       rcx,[rsp+40]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rsp+40]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0E10]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0E10]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1084],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+1086],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0E00]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0E00]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1088],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0DF0]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DF0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+108C],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+108E],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0DE0]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DE0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1090],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0DD0]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DD0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1094],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+1096],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0DC0]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DC0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1098],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0DB0]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DB0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+109C],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+109E],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0DA0]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DA0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10A0],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0D90]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D90]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10A4],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+10A6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0D80]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D80]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10A8],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0D70]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D70]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10AC],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+10AE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0D60]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D60]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10B0],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0D50]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D50]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10B4],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+10B6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0D40]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D40]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10B8],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0D30]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D30]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10BC],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+10BE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0D20]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D20]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10C0],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0D10]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D10]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10C4],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+10C6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0D00]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D00]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10C8],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0CF0]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0CF0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10CC],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rcx,[rsp+0FF0]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+10CE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       lea       rcx,[rsp+0CE0]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0CE0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10D0],eax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0CD0]
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0CD0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+10D4],ax
       lea       rcx,[rsp+0FF0]
       lea       rdx,[rsp+0FF0]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0FF8],0
       jbe       near ptr M00_L59
       mov       rdx,[rsp+0FF0]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+10D6],dl
       inc       edi
       cmp       edi,44521
       jl        near ptr M00_L02
       mov       rcx,rsi
       lea       rdx,[rsp+1010]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,10D8
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L05:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L06:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L07:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L08:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L10:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L11:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L12:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L13:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L14:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L15:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L16:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L17:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L18:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L19:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L20:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L21:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L22:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L23:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L24:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L25:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L26:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L27:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L28:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L29:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L30:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L31:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L32:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L33:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L34:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L35:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L36:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L37:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L38:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L39:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L40:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L41:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L42:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L43:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L44:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L45:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L46:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L47:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L48:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L49:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L50:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L51:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L52:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L53:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L54:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L55:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L56:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L57:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L58:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L59:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 12035
```
```assembly
; Internal.Runtime.CompilerServices.Unsafe.Add[[System.Byte, System.Private.CoreLib]](Byte ByRef, Int32)
       movsxd    rax,edx
       add       rax,rcx
       ret
; Total bytes of code 7
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       ret
; Total bytes of code 8
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
```
```assembly
; System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       sub       rsp,28
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       cmp       ecx,2
       jl        short M04_L00
       movzx     eax,word ptr [rax]
       add       rsp,28
       ret
M04_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 34
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       r8d,eax
       ja        short M05_L00
       mov       rcx,[rcx]
       sub       eax,r8d
       movsxd    r8,r8d
       add       rcx,r8
       mov       [rdx],rcx
       mov       [rdx+8],eax
       mov       rax,rdx
       add       rsp,28
       ret
M05_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 44
```
```assembly
; System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       sub       rsp,28
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       cmp       ecx,4
       jl        short M06_L00
       mov       eax,[rax]
       add       rsp,28
       ret
M06_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 33
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException()

## .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_ManualFieldForField_NoProgress()
       push      rdi
       push      rsi
       test      rax,[rsp+0F000]
       sub       rsp,1248
       vzeroupper
       mov       rsi,rcx
       lea       rdi,[rsp+20]
       mov       ecx,48A
       xor       eax,eax
       rep stosd
       mov       rcx,rsi
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+1180]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rcx,[rdi+8]
       lea       rax,[rsp+0CB0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       test      rcx,rcx
       jne       short M00_L00
       lea       rcx,[rsp+0CB0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       jmp       short M00_L01
M00_L00:
       lea       rax,[rcx+10]
       mov       [rsp+0CA8],rax
       mov       rax,[rsp+0CA8]
       lea       rdx,[rsp+0CB0]
       mov       [rdx],rax
       mov       ecx,[rcx+8]
       mov       [rsp+0CB8],ecx
M00_L01:
       vmovdqu   xmm0,xmmword ptr [rsp+0CB0]
       vmovdqu   xmmword ptr [rsp+1170],xmm0
       xor       edi,edi
M00_L02:
       vmovdqu   xmm0,xmmword ptr [rsp+1170]
       vmovdqu   xmmword ptr [rsp+1160],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+0C98],xmm0
       lea       rcx,[rsp+0C88]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+0C98]
       mov       eax,[rsp+0CA0]
       mov       [rsp+0C80],rcx
       mov       rcx,[rsp+0C80]
       lea       rdx,[rsp+0C88]
       mov       [rdx],rcx
       mov       [rsp+0C90],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0C88]
       vmovdqu   xmmword ptr [rsp+1150],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1150]
       vmovdqu   xmmword ptr [rsp+0C70],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],4
       jl        near ptr M00_L03
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+0C50],xmm0
       mov       rcx,[rsp+0C50]
       mov       ecx,[rcx]
       mov       [rsp+1180],ecx
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+0C40],xmm0
       lea       rcx,[rsp+0C30]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+0C40]
       mov       eax,[rsp+0C48]
       mov       [rsp+0C28],rcx
       mov       rcx,[rsp+0C28]
       lea       rdx,[rsp+0C30]
       mov       [rdx],rcx
       mov       [rsp+0C38],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0C30]
       vmovdqu   xmmword ptr [rsp+1140],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1140]
       vmovdqu   xmmword ptr [rsp+0C18],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C18]
       vmovdqu   xmmword ptr [rsp+0C08],xmm0
       cmp       dword ptr [rsp+0C10],2
       jl        near ptr M00_L04
       vmovdqu   xmm0,xmmword ptr [rsp+0C08]
       vmovdqu   xmmword ptr [rsp+0BF8],xmm0
       mov       rcx,[rsp+0BF8]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+1184],cx
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+0BE8],xmm0
       lea       rcx,[rsp+0BD8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+0BE8]
       mov       eax,[rsp+0BF0]
       mov       [rsp+0BD0],rcx
       mov       rcx,[rsp+0BD0]
       lea       rdx,[rsp+0BD8]
       mov       [rdx],rcx
       mov       [rsp+0BE0],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0BD8]
       vmovdqu   xmmword ptr [rsp+1130],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1130]
       vmovdqu   xmmword ptr [rsp+0BC0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0BC0]
       vmovdqu   xmmword ptr [rsp+0BB0],xmm0
       cmp       dword ptr [rsp+0BB8],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+0BB0]
       vmovdqu   xmmword ptr [rsp+0BA0],xmm0
       mov       rcx,[rsp+0BA0]
       mov       ecx,[rcx]
       mov       [rsp+1188],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L06
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+0B90]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+0B88],rcx
       mov       rcx,[rsp+0B88]
       lea       rdx,[rsp+0B90]
       mov       [rdx],rcx
       mov       [rsp+0B98],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0B90]
       vmovdqu   xmmword ptr [rsp+1120],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1120]
       vmovdqu   xmmword ptr [rsp+0B78],xmm0
       lea       rcx,[rsp+0B68]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+0B78]
       mov       eax,[rsp+0B80]
       mov       [rsp+0B60],rcx
       mov       rcx,[rsp+0B60]
       lea       rdx,[rsp+0B68]
       mov       [rdx],rcx
       mov       [rsp+0B70],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0B68]
       vmovdqu   xmmword ptr [rsp+1110],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1110]
       vmovdqu   xmmword ptr [rsp+0B50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0B50]
       vmovdqu   xmmword ptr [rsp+0B40],xmm0
       cmp       dword ptr [rsp+0B48],2
       jl        near ptr M00_L07
       vmovdqu   xmm0,xmmword ptr [rsp+0B40]
       vmovdqu   xmmword ptr [rsp+0B30],xmm0
       mov       rcx,[rsp+0B30]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+118C],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+118E],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+0B20],xmm0
       lea       rcx,[rsp+0B10]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+0B20]
       mov       eax,[rsp+0B28]
       mov       [rsp+0B08],rcx
       mov       rcx,[rsp+0B08]
       lea       rdx,[rsp+0B10]
       mov       [rdx],rcx
       mov       [rsp+0B18],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0B10]
       vmovdqu   xmmword ptr [rsp+1100],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1100]
       vmovdqu   xmmword ptr [rsp+0AF8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0AF8]
       vmovdqu   xmmword ptr [rsp+0AE8],xmm0
       cmp       dword ptr [rsp+0AF0],4
       jl        near ptr M00_L08
       vmovdqu   xmm0,xmmword ptr [rsp+0AE8]
       vmovdqu   xmmword ptr [rsp+0AD8],xmm0
       mov       rcx,[rsp+0AD8]
       mov       ecx,[rcx]
       mov       [rsp+1190],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L09
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+0AC8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+0AC0],rcx
       mov       rcx,[rsp+0AC0]
       lea       rdx,[rsp+0AC8]
       mov       [rdx],rcx
       mov       [rsp+0AD0],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0AC8]
       vmovdqu   xmmword ptr [rsp+10F0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+10F0]
       vmovdqu   xmmword ptr [rsp+0AB0],xmm0
       lea       rcx,[rsp+0AA0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+0AB0]
       mov       eax,[rsp+0AB8]
       mov       [rsp+0A98],rcx
       mov       rcx,[rsp+0A98]
       lea       rdx,[rsp+0AA0]
       mov       [rdx],rcx
       mov       [rsp+0AA8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0AA0]
       vmovdqu   xmmword ptr [rsp+10E0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+10E0]
       vmovdqu   xmmword ptr [rsp+0A88],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A88]
       vmovdqu   xmmword ptr [rsp+0A78],xmm0
       cmp       dword ptr [rsp+0A80],2
       jl        near ptr M00_L10
       vmovdqu   xmm0,xmmword ptr [rsp+0A78]
       vmovdqu   xmmword ptr [rsp+0A68],xmm0
       mov       rcx,[rsp+0A68]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+1194],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+1196],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+0A58],xmm0
       lea       rcx,[rsp+0A48]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+0A58]
       mov       eax,[rsp+0A60]
       mov       [rsp+0A40],rcx
       mov       rcx,[rsp+0A40]
       lea       rdx,[rsp+0A48]
       mov       [rdx],rcx
       mov       [rsp+0A50],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0A48]
       vmovdqu   xmmword ptr [rsp+10D0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+10D0]
       vmovdqu   xmmword ptr [rsp+0A30],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0A30]
       vmovdqu   xmmword ptr [rsp+0A20],xmm0
       cmp       dword ptr [rsp+0A28],4
       jl        near ptr M00_L11
       vmovdqu   xmm0,xmmword ptr [rsp+0A20]
       vmovdqu   xmmword ptr [rsp+0A10],xmm0
       mov       rcx,[rsp+0A10]
       mov       ecx,[rcx]
       mov       [rsp+1198],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L12
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+0A00]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+9F8],rcx
       mov       rcx,[rsp+9F8]
       lea       rdx,[rsp+0A00]
       mov       [rdx],rcx
       mov       [rsp+0A08],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0A00]
       vmovdqu   xmmword ptr [rsp+10C0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+10C0]
       vmovdqu   xmmword ptr [rsp+9E8],xmm0
       lea       rcx,[rsp+9D8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+9E8]
       mov       eax,[rsp+9F0]
       mov       [rsp+9D0],rcx
       mov       rcx,[rsp+9D0]
       lea       rdx,[rsp+9D8]
       mov       [rdx],rcx
       mov       [rsp+9E0],eax
       vmovdqu   xmm0,xmmword ptr [rsp+9D8]
       vmovdqu   xmmword ptr [rsp+10B0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+10B0]
       vmovdqu   xmmword ptr [rsp+9C0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+9C0]
       vmovdqu   xmmword ptr [rsp+9B0],xmm0
       cmp       dword ptr [rsp+9B8],2
       jl        near ptr M00_L13
       vmovdqu   xmm0,xmmword ptr [rsp+9B0]
       vmovdqu   xmmword ptr [rsp+9A0],xmm0
       mov       rcx,[rsp+9A0]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+119C],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+119E],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+990],xmm0
       lea       rcx,[rsp+980]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+990]
       mov       eax,[rsp+998]
       mov       [rsp+978],rcx
       mov       rcx,[rsp+978]
       lea       rdx,[rsp+980]
       mov       [rdx],rcx
       mov       [rsp+988],eax
       vmovdqu   xmm0,xmmword ptr [rsp+980]
       vmovdqu   xmmword ptr [rsp+10A0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+10A0]
       vmovdqu   xmmword ptr [rsp+968],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+968]
       vmovdqu   xmmword ptr [rsp+958],xmm0
       cmp       dword ptr [rsp+960],4
       jl        near ptr M00_L14
       vmovdqu   xmm0,xmmword ptr [rsp+958]
       vmovdqu   xmmword ptr [rsp+948],xmm0
       mov       rcx,[rsp+948]
       mov       ecx,[rcx]
       mov       [rsp+11A0],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L15
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+938]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+930],rcx
       mov       rcx,[rsp+930]
       lea       rdx,[rsp+938]
       mov       [rdx],rcx
       mov       [rsp+940],eax
       vmovdqu   xmm0,xmmword ptr [rsp+938]
       vmovdqu   xmmword ptr [rsp+1090],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1090]
       vmovdqu   xmmword ptr [rsp+920],xmm0
       lea       rcx,[rsp+910]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+920]
       mov       eax,[rsp+928]
       mov       [rsp+908],rcx
       mov       rcx,[rsp+908]
       lea       rdx,[rsp+910]
       mov       [rdx],rcx
       mov       [rsp+918],eax
       vmovdqu   xmm0,xmmword ptr [rsp+910]
       vmovdqu   xmmword ptr [rsp+1080],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1080]
       vmovdqu   xmmword ptr [rsp+8F8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+8F8]
       vmovdqu   xmmword ptr [rsp+8E8],xmm0
       cmp       dword ptr [rsp+8F0],2
       jl        near ptr M00_L16
       vmovdqu   xmm0,xmmword ptr [rsp+8E8]
       vmovdqu   xmmword ptr [rsp+8D8],xmm0
       mov       rcx,[rsp+8D8]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11A4],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11A6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+8C8],xmm0
       lea       rcx,[rsp+8B8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+8C8]
       mov       eax,[rsp+8D0]
       mov       [rsp+8B0],rcx
       mov       rcx,[rsp+8B0]
       lea       rdx,[rsp+8B8]
       mov       [rdx],rcx
       mov       [rsp+8C0],eax
       vmovdqu   xmm0,xmmword ptr [rsp+8B8]
       vmovdqu   xmmword ptr [rsp+1070],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1070]
       vmovdqu   xmmword ptr [rsp+8A0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+8A0]
       vmovdqu   xmmword ptr [rsp+890],xmm0
       cmp       dword ptr [rsp+898],4
       jl        near ptr M00_L17
       vmovdqu   xmm0,xmmword ptr [rsp+890]
       vmovdqu   xmmword ptr [rsp+880],xmm0
       mov       rcx,[rsp+880]
       mov       ecx,[rcx]
       mov       [rsp+11A8],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L18
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+870]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+868],rcx
       mov       rcx,[rsp+868]
       lea       rdx,[rsp+870]
       mov       [rdx],rcx
       mov       [rsp+878],eax
       vmovdqu   xmm0,xmmword ptr [rsp+870]
       vmovdqu   xmmword ptr [rsp+1060],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1060]
       vmovdqu   xmmword ptr [rsp+858],xmm0
       lea       rcx,[rsp+848]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+858]
       mov       eax,[rsp+860]
       mov       [rsp+840],rcx
       mov       rcx,[rsp+840]
       lea       rdx,[rsp+848]
       mov       [rdx],rcx
       mov       [rsp+850],eax
       vmovdqu   xmm0,xmmword ptr [rsp+848]
       vmovdqu   xmmword ptr [rsp+1050],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1050]
       vmovdqu   xmmword ptr [rsp+830],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+830]
       vmovdqu   xmmword ptr [rsp+820],xmm0
       cmp       dword ptr [rsp+828],2
       jl        near ptr M00_L19
       vmovdqu   xmm0,xmmword ptr [rsp+820]
       vmovdqu   xmmword ptr [rsp+810],xmm0
       mov       rcx,[rsp+810]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11AC],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11AE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+800],xmm0
       lea       rcx,[rsp+7F0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+800]
       mov       eax,[rsp+808]
       mov       [rsp+7E8],rcx
       mov       rcx,[rsp+7E8]
       lea       rdx,[rsp+7F0]
       mov       [rdx],rcx
       mov       [rsp+7F8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+7F0]
       vmovdqu   xmmword ptr [rsp+1040],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1040]
       vmovdqu   xmmword ptr [rsp+7D8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+7D8]
       vmovdqu   xmmword ptr [rsp+7C8],xmm0
       cmp       dword ptr [rsp+7D0],4
       jl        near ptr M00_L20
       vmovdqu   xmm0,xmmword ptr [rsp+7C8]
       vmovdqu   xmmword ptr [rsp+7B8],xmm0
       mov       rcx,[rsp+7B8]
       mov       ecx,[rcx]
       mov       [rsp+11B0],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L21
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+7A8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+7A0],rcx
       mov       rcx,[rsp+7A0]
       lea       rdx,[rsp+7A8]
       mov       [rdx],rcx
       mov       [rsp+7B0],eax
       vmovdqu   xmm0,xmmword ptr [rsp+7A8]
       vmovdqu   xmmword ptr [rsp+1030],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1030]
       vmovdqu   xmmword ptr [rsp+790],xmm0
       lea       rcx,[rsp+780]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+790]
       mov       eax,[rsp+798]
       mov       [rsp+778],rcx
       mov       rcx,[rsp+778]
       lea       rdx,[rsp+780]
       mov       [rdx],rcx
       mov       [rsp+788],eax
       vmovdqu   xmm0,xmmword ptr [rsp+780]
       vmovdqu   xmmword ptr [rsp+1020],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1020]
       vmovdqu   xmmword ptr [rsp+768],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+768]
       vmovdqu   xmmword ptr [rsp+758],xmm0
       cmp       dword ptr [rsp+760],2
       jl        near ptr M00_L22
       vmovdqu   xmm0,xmmword ptr [rsp+758]
       vmovdqu   xmmword ptr [rsp+748],xmm0
       mov       rcx,[rsp+748]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11B4],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11B6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+738],xmm0
       lea       rcx,[rsp+728]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+738]
       mov       eax,[rsp+740]
       mov       [rsp+720],rcx
       mov       rcx,[rsp+720]
       lea       rdx,[rsp+728]
       mov       [rdx],rcx
       mov       [rsp+730],eax
       vmovdqu   xmm0,xmmword ptr [rsp+728]
       vmovdqu   xmmword ptr [rsp+1010],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1010]
       vmovdqu   xmmword ptr [rsp+710],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+710]
       vmovdqu   xmmword ptr [rsp+700],xmm0
       cmp       dword ptr [rsp+708],4
       jl        near ptr M00_L23
       vmovdqu   xmm0,xmmword ptr [rsp+700]
       vmovdqu   xmmword ptr [rsp+6F0],xmm0
       mov       rcx,[rsp+6F0]
       mov       ecx,[rcx]
       mov       [rsp+11B8],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L24
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+6E0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+6D8],rcx
       mov       rcx,[rsp+6D8]
       lea       rdx,[rsp+6E0]
       mov       [rdx],rcx
       mov       [rsp+6E8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+6E0]
       vmovdqu   xmmword ptr [rsp+1000],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1000]
       vmovdqu   xmmword ptr [rsp+6C8],xmm0
       lea       rcx,[rsp+6B8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+6C8]
       mov       eax,[rsp+6D0]
       mov       [rsp+6B0],rcx
       mov       rcx,[rsp+6B0]
       lea       rdx,[rsp+6B8]
       mov       [rdx],rcx
       mov       [rsp+6C0],eax
       vmovdqu   xmm0,xmmword ptr [rsp+6B8]
       vmovdqu   xmmword ptr [rsp+0FF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FF0]
       vmovdqu   xmmword ptr [rsp+6A0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+6A0]
       vmovdqu   xmmword ptr [rsp+690],xmm0
       cmp       dword ptr [rsp+698],2
       jl        near ptr M00_L25
       vmovdqu   xmm0,xmmword ptr [rsp+690]
       vmovdqu   xmmword ptr [rsp+680],xmm0
       mov       rcx,[rsp+680]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11BC],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11BE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+670],xmm0
       lea       rcx,[rsp+660]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+670]
       mov       eax,[rsp+678]
       mov       [rsp+658],rcx
       mov       rcx,[rsp+658]
       lea       rdx,[rsp+660]
       mov       [rdx],rcx
       mov       [rsp+668],eax
       vmovdqu   xmm0,xmmword ptr [rsp+660]
       vmovdqu   xmmword ptr [rsp+0FE0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FE0]
       vmovdqu   xmmword ptr [rsp+648],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+648]
       vmovdqu   xmmword ptr [rsp+638],xmm0
       cmp       dword ptr [rsp+640],4
       jl        near ptr M00_L26
       vmovdqu   xmm0,xmmword ptr [rsp+638]
       vmovdqu   xmmword ptr [rsp+628],xmm0
       mov       rcx,[rsp+628]
       mov       ecx,[rcx]
       mov       [rsp+11C0],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L27
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+618]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+610],rcx
       mov       rcx,[rsp+610]
       lea       rdx,[rsp+618]
       mov       [rdx],rcx
       mov       [rsp+620],eax
       vmovdqu   xmm0,xmmword ptr [rsp+618]
       vmovdqu   xmmword ptr [rsp+0FD0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FD0]
       vmovdqu   xmmword ptr [rsp+600],xmm0
       lea       rcx,[rsp+5F0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+600]
       mov       eax,[rsp+608]
       mov       [rsp+5E8],rcx
       mov       rcx,[rsp+5E8]
       lea       rdx,[rsp+5F0]
       mov       [rdx],rcx
       mov       [rsp+5F8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+5F0]
       vmovdqu   xmmword ptr [rsp+0FC0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FC0]
       vmovdqu   xmmword ptr [rsp+5D8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+5D8]
       vmovdqu   xmmword ptr [rsp+5C8],xmm0
       cmp       dword ptr [rsp+5D0],2
       jl        near ptr M00_L28
       vmovdqu   xmm0,xmmword ptr [rsp+5C8]
       vmovdqu   xmmword ptr [rsp+5B8],xmm0
       mov       rcx,[rsp+5B8]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11C4],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11C6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+5A8],xmm0
       lea       rcx,[rsp+598]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+5A8]
       mov       eax,[rsp+5B0]
       mov       [rsp+590],rcx
       mov       rcx,[rsp+590]
       lea       rdx,[rsp+598]
       mov       [rdx],rcx
       mov       [rsp+5A0],eax
       vmovdqu   xmm0,xmmword ptr [rsp+598]
       vmovdqu   xmmword ptr [rsp+0FB0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FB0]
       vmovdqu   xmmword ptr [rsp+580],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+580]
       vmovdqu   xmmword ptr [rsp+570],xmm0
       cmp       dword ptr [rsp+578],4
       jl        near ptr M00_L29
       vmovdqu   xmm0,xmmword ptr [rsp+570]
       vmovdqu   xmmword ptr [rsp+560],xmm0
       mov       rcx,[rsp+560]
       mov       ecx,[rcx]
       mov       [rsp+11C8],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L30
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+550]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+548],rcx
       mov       rcx,[rsp+548]
       lea       rdx,[rsp+550]
       mov       [rdx],rcx
       mov       [rsp+558],eax
       vmovdqu   xmm0,xmmword ptr [rsp+550]
       vmovdqu   xmmword ptr [rsp+0FA0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0FA0]
       vmovdqu   xmmword ptr [rsp+538],xmm0
       lea       rcx,[rsp+528]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+538]
       mov       eax,[rsp+540]
       mov       [rsp+520],rcx
       mov       rcx,[rsp+520]
       lea       rdx,[rsp+528]
       mov       [rdx],rcx
       mov       [rsp+530],eax
       vmovdqu   xmm0,xmmword ptr [rsp+528]
       vmovdqu   xmmword ptr [rsp+0F90],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F90]
       vmovdqu   xmmword ptr [rsp+510],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+510]
       vmovdqu   xmmword ptr [rsp+500],xmm0
       cmp       dword ptr [rsp+508],2
       jl        near ptr M00_L31
       vmovdqu   xmm0,xmmword ptr [rsp+500]
       vmovdqu   xmmword ptr [rsp+4F0],xmm0
       mov       rcx,[rsp+4F0]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11CC],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11CE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+4E0],xmm0
       lea       rcx,[rsp+4D0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+4E0]
       mov       eax,[rsp+4E8]
       mov       [rsp+4C8],rcx
       mov       rcx,[rsp+4C8]
       lea       rdx,[rsp+4D0]
       mov       [rdx],rcx
       mov       [rsp+4D8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+4D0]
       vmovdqu   xmmword ptr [rsp+0F80],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F80]
       vmovdqu   xmmword ptr [rsp+4B8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+4B8]
       vmovdqu   xmmword ptr [rsp+4A8],xmm0
       cmp       dword ptr [rsp+4B0],4
       jl        near ptr M00_L32
       vmovdqu   xmm0,xmmword ptr [rsp+4A8]
       vmovdqu   xmmword ptr [rsp+498],xmm0
       mov       rcx,[rsp+498]
       mov       ecx,[rcx]
       mov       [rsp+11D0],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L33
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+488]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+480],rcx
       mov       rcx,[rsp+480]
       lea       rdx,[rsp+488]
       mov       [rdx],rcx
       mov       [rsp+490],eax
       vmovdqu   xmm0,xmmword ptr [rsp+488]
       vmovdqu   xmmword ptr [rsp+0F70],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F70]
       vmovdqu   xmmword ptr [rsp+470],xmm0
       lea       rcx,[rsp+460]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+470]
       mov       eax,[rsp+478]
       mov       [rsp+458],rcx
       mov       rcx,[rsp+458]
       lea       rdx,[rsp+460]
       mov       [rdx],rcx
       mov       [rsp+468],eax
       vmovdqu   xmm0,xmmword ptr [rsp+460]
       vmovdqu   xmmword ptr [rsp+0F60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F60]
       vmovdqu   xmmword ptr [rsp+448],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+448]
       vmovdqu   xmmword ptr [rsp+438],xmm0
       cmp       dword ptr [rsp+440],2
       jl        near ptr M00_L34
       vmovdqu   xmm0,xmmword ptr [rsp+438]
       vmovdqu   xmmword ptr [rsp+428],xmm0
       mov       rcx,[rsp+428]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11D4],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11D6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+418],xmm0
       lea       rcx,[rsp+408]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+418]
       mov       eax,[rsp+420]
       mov       [rsp+400],rcx
       mov       rcx,[rsp+400]
       lea       rdx,[rsp+408]
       mov       [rdx],rcx
       mov       [rsp+410],eax
       vmovdqu   xmm0,xmmword ptr [rsp+408]
       vmovdqu   xmmword ptr [rsp+0F50],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F50]
       vmovdqu   xmmword ptr [rsp+3F0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+3F0]
       vmovdqu   xmmword ptr [rsp+3E0],xmm0
       cmp       dword ptr [rsp+3E8],4
       jl        near ptr M00_L35
       vmovdqu   xmm0,xmmword ptr [rsp+3E0]
       vmovdqu   xmmword ptr [rsp+3D0],xmm0
       mov       rcx,[rsp+3D0]
       mov       ecx,[rcx]
       mov       [rsp+11D8],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L36
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+3C0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+3B8],rcx
       mov       rcx,[rsp+3B8]
       lea       rdx,[rsp+3C0]
       mov       [rdx],rcx
       mov       [rsp+3C8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+3C0]
       vmovdqu   xmmword ptr [rsp+0F40],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F40]
       vmovdqu   xmmword ptr [rsp+3A8],xmm0
       lea       rcx,[rsp+398]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+3A8]
       mov       eax,[rsp+3B0]
       mov       [rsp+390],rcx
       mov       rcx,[rsp+390]
       lea       rdx,[rsp+398]
       mov       [rdx],rcx
       mov       [rsp+3A0],eax
       vmovdqu   xmm0,xmmword ptr [rsp+398]
       vmovdqu   xmmword ptr [rsp+0F30],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F30]
       vmovdqu   xmmword ptr [rsp+380],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+380]
       vmovdqu   xmmword ptr [rsp+370],xmm0
       cmp       dword ptr [rsp+378],2
       jl        near ptr M00_L37
       vmovdqu   xmm0,xmmword ptr [rsp+370]
       vmovdqu   xmmword ptr [rsp+360],xmm0
       mov       rcx,[rsp+360]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11DC],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11DE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+350],xmm0
       lea       rcx,[rsp+340]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+350]
       mov       eax,[rsp+358]
       mov       [rsp+338],rcx
       mov       rcx,[rsp+338]
       lea       rdx,[rsp+340]
       mov       [rdx],rcx
       mov       [rsp+348],eax
       vmovdqu   xmm0,xmmword ptr [rsp+340]
       vmovdqu   xmmword ptr [rsp+0F20],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F20]
       vmovdqu   xmmword ptr [rsp+328],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+328]
       vmovdqu   xmmword ptr [rsp+318],xmm0
       cmp       dword ptr [rsp+320],4
       jl        near ptr M00_L38
       vmovdqu   xmm0,xmmword ptr [rsp+318]
       vmovdqu   xmmword ptr [rsp+308],xmm0
       mov       rcx,[rsp+308]
       mov       ecx,[rcx]
       mov       [rsp+11E0],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L39
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+2F8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+2F0],rcx
       mov       rcx,[rsp+2F0]
       lea       rdx,[rsp+2F8]
       mov       [rdx],rcx
       mov       [rsp+300],eax
       vmovdqu   xmm0,xmmword ptr [rsp+2F8]
       vmovdqu   xmmword ptr [rsp+0F10],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F10]
       vmovdqu   xmmword ptr [rsp+2E0],xmm0
       lea       rcx,[rsp+2D0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+2E0]
       mov       eax,[rsp+2E8]
       mov       [rsp+2C8],rcx
       mov       rcx,[rsp+2C8]
       lea       rdx,[rsp+2D0]
       mov       [rdx],rcx
       mov       [rsp+2D8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+2D0]
       vmovdqu   xmmword ptr [rsp+0F00],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F00]
       vmovdqu   xmmword ptr [rsp+2B8],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+2B8]
       vmovdqu   xmmword ptr [rsp+2A8],xmm0
       cmp       dword ptr [rsp+2B0],2
       jl        near ptr M00_L40
       vmovdqu   xmm0,xmmword ptr [rsp+2A8]
       vmovdqu   xmmword ptr [rsp+298],xmm0
       mov       rcx,[rsp+298]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11E4],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11E6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+288],xmm0
       lea       rcx,[rsp+278]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+288]
       mov       eax,[rsp+290]
       mov       [rsp+270],rcx
       mov       rcx,[rsp+270]
       lea       rdx,[rsp+278]
       mov       [rdx],rcx
       mov       [rsp+280],eax
       vmovdqu   xmm0,xmmword ptr [rsp+278]
       vmovdqu   xmmword ptr [rsp+0EF0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EF0]
       vmovdqu   xmmword ptr [rsp+260],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+260]
       vmovdqu   xmmword ptr [rsp+250],xmm0
       cmp       dword ptr [rsp+258],4
       jl        near ptr M00_L41
       vmovdqu   xmm0,xmmword ptr [rsp+250]
       vmovdqu   xmmword ptr [rsp+240],xmm0
       mov       rcx,[rsp+240]
       mov       ecx,[rcx]
       mov       [rsp+11E8],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L42
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+230]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+228],rcx
       mov       rcx,[rsp+228]
       lea       rdx,[rsp+230]
       mov       [rdx],rcx
       mov       [rsp+238],eax
       vmovdqu   xmm0,xmmword ptr [rsp+230]
       vmovdqu   xmmword ptr [rsp+0EE0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EE0]
       vmovdqu   xmmword ptr [rsp+218],xmm0
       lea       rcx,[rsp+208]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+218]
       mov       eax,[rsp+220]
       mov       [rsp+200],rcx
       mov       rcx,[rsp+200]
       lea       rdx,[rsp+208]
       mov       [rdx],rcx
       mov       [rsp+210],eax
       vmovdqu   xmm0,xmmword ptr [rsp+208]
       vmovdqu   xmmword ptr [rsp+0ED0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0ED0]
       vmovdqu   xmmword ptr [rsp+1F0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1F0]
       vmovdqu   xmmword ptr [rsp+1E0],xmm0
       cmp       dword ptr [rsp+1E8],2
       jl        near ptr M00_L43
       vmovdqu   xmm0,xmmword ptr [rsp+1E0]
       vmovdqu   xmmword ptr [rsp+1D0],xmm0
       mov       rcx,[rsp+1D0]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11EC],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11EE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+1C0],xmm0
       lea       rcx,[rsp+1B0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+1C0]
       mov       eax,[rsp+1C8]
       mov       [rsp+1A8],rcx
       mov       rcx,[rsp+1A8]
       lea       rdx,[rsp+1B0]
       mov       [rdx],rcx
       mov       [rsp+1B8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+1B0]
       vmovdqu   xmmword ptr [rsp+0EC0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EC0]
       vmovdqu   xmmword ptr [rsp+198],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+198]
       vmovdqu   xmmword ptr [rsp+188],xmm0
       cmp       dword ptr [rsp+190],4
       jl        near ptr M00_L44
       vmovdqu   xmm0,xmmword ptr [rsp+188]
       vmovdqu   xmmword ptr [rsp+178],xmm0
       mov       rcx,[rsp+178]
       mov       ecx,[rcx]
       mov       [rsp+11F0],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L45
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+168]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+160],rcx
       mov       rcx,[rsp+160]
       lea       rdx,[rsp+168]
       mov       [rdx],rcx
       mov       [rsp+170],eax
       vmovdqu   xmm0,xmmword ptr [rsp+168]
       vmovdqu   xmmword ptr [rsp+0EB0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EB0]
       vmovdqu   xmmword ptr [rsp+150],xmm0
       lea       rcx,[rsp+140]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+150]
       mov       eax,[rsp+158]
       mov       [rsp+138],rcx
       mov       rcx,[rsp+138]
       lea       rdx,[rsp+140]
       mov       [rdx],rcx
       mov       [rsp+148],eax
       vmovdqu   xmm0,xmmword ptr [rsp+140]
       vmovdqu   xmmword ptr [rsp+0EA0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0EA0]
       vmovdqu   xmmword ptr [rsp+128],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+128]
       vmovdqu   xmmword ptr [rsp+118],xmm0
       cmp       dword ptr [rsp+120],2
       jl        near ptr M00_L46
       vmovdqu   xmm0,xmmword ptr [rsp+118]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       mov       rcx,[rsp+108]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+11F4],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11F6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+0F8],xmm0
       lea       rcx,[rsp+0E8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+0F8]
       mov       eax,[rsp+100]
       mov       [rsp+0E0],rcx
       mov       rcx,[rsp+0E0]
       lea       rdx,[rsp+0E8]
       mov       [rdx],rcx
       mov       [rsp+0F0],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0E8]
       vmovdqu   xmmword ptr [rsp+0E90],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E90]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       cmp       dword ptr [rsp+0C8],4
       jl        near ptr M00_L47
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+0B0],xmm0
       mov       rcx,[rsp+0B0]
       mov       ecx,[rcx]
       mov       [rsp+11F8],ecx
       cmp       dword ptr [rsp+1168],4
       jb        near ptr M00_L48
       mov       rcx,[rsp+1160]
       lea       rax,[rsp+0A0]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rax],xmm0
       mov       eax,[rsp+1168]
       add       eax,0FFFFFFFC
       add       rcx,4
       mov       [rsp+98],rcx
       mov       rcx,[rsp+98]
       lea       rdx,[rsp+0A0]
       mov       [rdx],rcx
       mov       [rsp+0A8],eax
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+0E80],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E80]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       lea       rcx,[rsp+78]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rcx],xmm0
       mov       rcx,[rsp+88]
       mov       eax,[rsp+90]
       mov       [rsp+70],rcx
       mov       rcx,[rsp+70]
       lea       rdx,[rsp+78]
       mov       [rdx],rcx
       mov       [rsp+80],eax
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+0E70],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0E70]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+60]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       cmp       dword ptr [rsp+58],2
       jl        near ptr M00_L49
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rsp+40]
       call      Internal.Runtime.CompilerServices.Unsafe.ReadUnaligned[[System.UInt16, System.Private.CoreLib]](Byte ByRef)
       movzx     ecx,ax
       mov       [rsp+11FC],cx
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+11FE],cl
       lea       rcx,[rsp+0E60]
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0E60]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1200],eax
       lea       rcx,[rsp+1160]
       lea       rdx,[rsp+0E50]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0E40]
       vmovdqu   xmm0,xmmword ptr [rsp+0E50]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0E40]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1204],ax
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+1206],cl
       lea       rcx,[rsp+0E30]
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0E30]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1208],eax
       lea       rcx,[rsp+1160]
       lea       rdx,[rsp+0E20]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0E10]
       vmovdqu   xmm0,xmmword ptr [rsp+0E20]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0E10]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+120C],ax
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+120E],cl
       lea       rcx,[rsp+0E00]
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0E00]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1210],eax
       lea       rcx,[rsp+1160]
       lea       rdx,[rsp+0DF0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0DE0]
       vmovdqu   xmm0,xmmword ptr [rsp+0DF0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DE0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1214],ax
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+1216],cl
       lea       rcx,[rsp+0DD0]
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DD0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1218],eax
       lea       rcx,[rsp+1160]
       lea       rdx,[rsp+0DC0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0DB0]
       vmovdqu   xmm0,xmmword ptr [rsp+0DC0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DB0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+121C],ax
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+121E],cl
       lea       rcx,[rsp+0DA0]
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0DA0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1220],eax
       lea       rcx,[rsp+1160]
       lea       rdx,[rsp+0D90]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0D80]
       vmovdqu   xmm0,xmmword ptr [rsp+0D90]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D80]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1224],ax
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+1226],cl
       lea       rcx,[rsp+0D70]
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D70]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1228],eax
       lea       rcx,[rsp+1160]
       lea       rdx,[rsp+0D60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0D50]
       vmovdqu   xmm0,xmmword ptr [rsp+0D60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D50]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+122C],ax
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+122E],cl
       lea       rcx,[rsp+0D40]
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D40]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1230],eax
       lea       rcx,[rsp+1160]
       lea       rdx,[rsp+0D30]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0D20]
       vmovdqu   xmm0,xmmword ptr [rsp+0D30]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D20]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1234],ax
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+1236],cl
       lea       rcx,[rsp+0D10]
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0D10]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1238],eax
       lea       rcx,[rsp+1160]
       lea       rdx,[rsp+0D00]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0CF0]
       vmovdqu   xmm0,xmmword ptr [rsp+0D00]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0CF0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+123C],ax
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rcx,[rsp+1160]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+123E],cl
       lea       rcx,[rsp+0CE0]
       vmovdqu   xmm0,xmmword ptr [rsp+1160]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0CE0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1240],eax
       lea       rcx,[rsp+1160]
       lea       rdx,[rsp+0CD0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0CC0]
       vmovdqu   xmm0,xmmword ptr [rsp+0CD0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0CC0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+1244],ax
       cmp       dword ptr [rsp+1168],6
       jbe       near ptr M00_L50
       mov       rdx,[rsp+1160]
       movzx     edx,byte ptr [rdx+6]
       mov       [rsp+1246],dl
       inc       edi
       cmp       edi,44521
       jl        near ptr M00_L02
       mov       rcx,rsi
       lea       rdx,[rsp+1180]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,1248
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L04:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L05:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L06:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L07:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L08:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L10:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L11:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L12:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L13:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L14:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L15:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L16:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L17:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L18:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L19:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L20:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L21:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L22:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L23:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L24:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L25:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L26:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L27:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L28:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L29:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L30:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L31:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L32:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L33:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L34:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L35:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L36:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L37:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L38:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L39:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L40:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L41:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L42:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L43:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L44:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L45:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L46:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L47:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L48:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L49:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 10413
```
```assembly
; Internal.Runtime.CompilerServices.Unsafe.ReadUnaligned[[System.UInt16, System.Private.CoreLib]](Byte ByRef)
       movzx     eax,word ptr [rcx]
       ret
; Total bytes of code 4
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       ret
; Total bytes of code 16
```
```assembly
; System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       sub       rsp,28
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       cmp       ecx,4
       jl        short M03_L00
       mov       eax,[rax]
       add       rsp,28
       ret
M03_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 33
```
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       r8d,eax
       ja        short M04_L00
       mov       rcx,[rcx]
       sub       eax,r8d
       movsxd    r8,r8d
       add       rcx,r8
       mov       [rdx],rcx
       mov       [rdx+8],eax
       mov       rax,rdx
       add       rsp,28
       ret
M04_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 44
```
```assembly
; System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       sub       rsp,28
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       cmp       ecx,2
       jl        short M05_L00
       movzx     eax,word ptr [rax]
       add       rsp,28
       ret
M05_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 34
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

