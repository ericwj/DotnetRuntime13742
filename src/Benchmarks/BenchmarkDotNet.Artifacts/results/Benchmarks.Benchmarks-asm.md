## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_NoInlining()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+28]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdi,[rdi+8]
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M00_L02
       add       rdi,10
       xor       ebx,ebx
M00_L01:
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
       jl        near ptr M00_L01
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
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 541
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.A, Benchmarks]](Byte ByRef, Benchmarks.A ByRef)
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.UInt32, System.Private.CoreLib]](Byte ByRef, UInt32 ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.B, Benchmarks]](Byte ByRef, Benchmarks.B ByRef)
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.UInt16, System.Private.CoreLib]](Byte ByRef, UInt16 ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.C, Benchmarks]](Byte ByRef, Benchmarks.C ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.C ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.D, Benchmarks]](Byte ByRef, Benchmarks.D ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.D ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.E, Benchmarks]](Byte ByRef, Benchmarks.E ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.E ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.F, Benchmarks]](Byte ByRef, Benchmarks.F ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.F ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](Byte ByRef, Benchmarks.G ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.G ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](Byte ByRef, Benchmarks.H ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.H ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](Byte ByRef, Benchmarks.I ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.I ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](Byte ByRef, Benchmarks.J ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.J ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](Byte ByRef, Benchmarks.K ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.K ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](Byte ByRef, Benchmarks.L ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.L ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](Byte ByRef, Benchmarks.M ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.M ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](Byte ByRef, Benchmarks.N ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.N ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](Byte ByRef, Benchmarks.O ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.O ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](Byte ByRef, Benchmarks.P ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.P ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](Byte ByRef, Benchmarks.Q ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.Q ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](Byte ByRef, Benchmarks.R ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.R ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](Byte ByRef, Benchmarks.S ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.S ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](Byte ByRef, Benchmarks.T ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.T ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](Byte ByRef, Benchmarks.U ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.U ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](Byte ByRef, Benchmarks.V ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.V ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](Byte ByRef, Benchmarks.W ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.W ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](Byte ByRef, Benchmarks.X ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.X ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](Byte ByRef, Benchmarks.Y ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.Y ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](Byte ByRef, Benchmarks.Z ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(Byte ByRef, Benchmarks.Z ByRef)
; Total bytes of code 5
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
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
       add       rsp,20
       pop       rsi
       jmp       near ptr Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
; Total bytes of code 47
```
```assembly
; Benchmarks.NoInlining.ReadField[[System.Byte, System.Private.CoreLib]](Byte ByRef, Byte ByRef)
       movzx     eax,byte ptr [rcx]
       mov       [rdx],al
       lea       rax,[rcx+1]
       ret
; Total bytes of code 10
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_FullInlining()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0F8
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0F0],rax
       mov       [rsp+148],rdx
       mov       rdi,rcx
       xor       edx,edx
       lea       rcx,[rsp+30]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M00_L02
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
       lea       r12,[rdx+4]
M00_L01:
       lea       r13,[rsp+30]
       mov       esi,[rdx]
       mov       [r13],esi
       lea       rsi,[rsp+34]
       movzx     r13d,word ptr [rdx]
       mov       [rsi],r13w
       lea       rsi,[rsp+38]
       mov       r13d,[rdx]
       mov       [rsi],r13d
       mov       [rsp+28],r8
       mov       rsi,r8
       lea       r13,[rsp+3C]
       movzx     r8d,word ptr [rsi]
       mov       [r13],r8w
       add       rsi,2
       lea       r8,[rsp+3E]
       movzx     esi,byte ptr [rsi]
       mov       [r8],sil
       lea       r8,[rsp+40]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,rax
       lea       rsi,[rsp+44]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+46]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+48]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,r9
       lea       rsi,[rsp+4C]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+4E]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+50]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,r10
       lea       rsi,[rsp+54]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+56]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+58]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,r11
       lea       rsi,[rsp+5C]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+5E]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+60]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,rdi
       lea       rsi,[rsp+64]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+66]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+68]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,rbx
       lea       rsi,[rsp+6C]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+6E]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+70]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,rbp
       lea       rsi,[rsp+74]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+76]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+78]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,r14
       lea       rsi,[rsp+7C]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+7E]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+80]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,r15
       lea       rsi,[rsp+84]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+86]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+88]
       mov       esi,[rdx]
       mov       [r8],esi
       mov       r8,r12
       lea       rsi,[rsp+8C]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+8E]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+90]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+94]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+96]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+98]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+9C]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+9E]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0A0]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0A4]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0A6]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0A8]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0AC]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0AE]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0B0]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0B4]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0B6]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0B8]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0BC]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0BE]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0C0]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0C4]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0C6]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0C8]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0CC]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0CE]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0D0]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0D4]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0D6]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0D8]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0DC]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0DE]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0E0]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0E4]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0E6]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0E8]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0EC]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0EE]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       lea       r8,[rsp+0F0]
       mov       esi,[rdx]
       mov       [r8],esi
       lea       r8,[rdx+4]
       lea       rsi,[rsp+0F4]
       movzx     r13d,word ptr [r8]
       mov       [rsi],r13w
       add       r8,2
       lea       rsi,[rsp+0F6]
       movzx     r8d,byte ptr [r8]
       mov       [rsi],r8b
       inc       ecx
       cmp       ecx,44521
       mov       r8,[rsp+28]
       jl        near ptr M00_L01
       mov       rsi,[rsp+148]
       mov       rcx,rsi
       lea       rdx,[rsp+30]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,0F8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1429
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_InlineFieldReads()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+28]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdi,[rdi+8]
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M00_L02
       add       rdi,10
       xor       ebx,ebx
M00_L01:
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
       jl        near ptr M00_L01
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
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 541
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
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.C ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.D, Benchmarks]](Byte ByRef, Benchmarks.D ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.D ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.E, Benchmarks]](Byte ByRef, Benchmarks.E ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.E ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.F, Benchmarks]](Byte ByRef, Benchmarks.F ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.F ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.G, Benchmarks]](Byte ByRef, Benchmarks.G ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.G ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.H, Benchmarks]](Byte ByRef, Benchmarks.H ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.H ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.I, Benchmarks]](Byte ByRef, Benchmarks.I ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.I ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.J, Benchmarks]](Byte ByRef, Benchmarks.J ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.J ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.K, Benchmarks]](Byte ByRef, Benchmarks.K ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.K ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.L, Benchmarks]](Byte ByRef, Benchmarks.L ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.L ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.M, Benchmarks]](Byte ByRef, Benchmarks.M ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.M ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.N, Benchmarks]](Byte ByRef, Benchmarks.N ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.N ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.O, Benchmarks]](Byte ByRef, Benchmarks.O ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.O ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.P, Benchmarks]](Byte ByRef, Benchmarks.P ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.P ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Q, Benchmarks]](Byte ByRef, Benchmarks.Q ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.Q ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.R, Benchmarks]](Byte ByRef, Benchmarks.R ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.R ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.S, Benchmarks]](Byte ByRef, Benchmarks.S ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.S ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.T, Benchmarks]](Byte ByRef, Benchmarks.T ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.T ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.U, Benchmarks]](Byte ByRef, Benchmarks.U ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.U ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.V, Benchmarks]](Byte ByRef, Benchmarks.V ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.V ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.W, Benchmarks]](Byte ByRef, Benchmarks.W ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.W ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.X, Benchmarks]](Byte ByRef, Benchmarks.X ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.X ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Y, Benchmarks]](Byte ByRef, Benchmarks.Y ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.Y ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Z, Benchmarks]](Byte ByRef, Benchmarks.Z ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(Byte ByRef, Benchmarks.Z ByRef)
; Total bytes of code 5
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

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_InlineStructReads()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+28]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdi,[rdi+8]
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M00_L02
       add       rdi,10
       xor       ebx,ebx
M00_L01:
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
       jl        near ptr M00_L01
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
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1249
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

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
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
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0E0],rax
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+20]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdx,[rdi+8]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M00_L02
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
M00_L01:
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
       jl        near ptr M00_L01
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
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1233
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromByteRef_ManualFieldForField_BigData()
       push      rdi
       push      rsi
       sub       rsp,0E8
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0E0],rax
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+20]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdx,[rdi+30]
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M00_L02
       add       rdx,10
       xor       ecx,ecx
       lea       r8,[rdx+4]
M00_L01:
       mov       eax,[rdx]
       mov       [rsp+20],eax
       mov       rax,r8
       movzx     r9d,word ptr [rax]
       mov       [rsp+24],r9w
       add       rax,2
       mov       r9d,[rax]
       mov       [rsp+28],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+2C],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+2E],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+30],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+34],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+36],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+38],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+3C],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+3E],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+40],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+44],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+46],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+48],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+4C],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+4E],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+50],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+54],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+56],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+58],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+5C],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+5E],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+60],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+64],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+66],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+68],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+6C],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+6E],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+70],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+74],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+76],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+78],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+7C],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+7E],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+80],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+84],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+86],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+88],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+8C],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+8E],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+90],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+94],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+96],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+98],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+9C],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+9E],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+0A0],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+0A4],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+0A6],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+0A8],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+0AC],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+0AE],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+0B0],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+0B4],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+0B6],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+0B8],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+0BC],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+0BE],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+0C0],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+0C4],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+0C6],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+0C8],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+0CC],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+0CE],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+0D0],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+0D4],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+0D6],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+0D8],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+0DC],r9w
       add       rax,2
       movzx     r9d,byte ptr [rax]
       mov       [rsp+0DE],r9b
       inc       rax
       mov       r9d,[rax]
       mov       [rsp+0E0],r9d
       add       rax,4
       movzx     r9d,word ptr [rax]
       mov       [rsp+0E4],r9w
       add       rax,2
       movzx     eax,byte ptr [rax]
       mov       [rsp+0E6],al
       inc       ecx
       cmp       ecx,44521
       jl        near ptr M00_L01
       mov       rcx,rsi
       lea       rdx,[rsp+20]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,0E8
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1211
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_NoInlining()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,298
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFD90
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+290],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2B0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+290],rax
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+1D0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rcx,[rdi+8]
       test      rcx,rcx
       jne       short M00_L01
       xor       edi,edi
       xor       ebx,ebx
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rcx+10]
       mov       ebx,[rcx+8]
M00_L02:
       xor       ebp,ebp
M00_L03:
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
       jl        near ptr M00_L03
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
; Total bytes of code 1115
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
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.C ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.D, Benchmarks]](System.Span`1<Byte>, Benchmarks.D ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.D ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.E, Benchmarks]](System.Span`1<Byte>, Benchmarks.E ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.E ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.F, Benchmarks]](System.Span`1<Byte>, Benchmarks.F ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.F ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.G ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.H ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.I ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.J ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.K ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.L ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.M ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.N ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.O ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.P ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Q ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.R ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.S ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.T ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.U ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.V ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.W ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.X ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Y ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.NoInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       jmp       near ptr Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Z ByRef)
; Total bytes of code 5
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
       jl        short M28_L01
       movzx     r9d,word ptr [rax]
       mov       [r8],r9w
       cmp       edx,2
       jb        short M28_L00
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M28_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M28_L01:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 66
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.C ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.D ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.E ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.F ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.G ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.H ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.I ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.J ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.K ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.L ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.M ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.N ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.O ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.P ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Q ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.R ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.S ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.T ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.U ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.V ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.W ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.X ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Y ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
```
```assembly
; Benchmarks.NoInlining.TryRead(System.Span`1<Byte>, Benchmarks.Z ByRef)
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
; Total bytes of code 145
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

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_FullInlining()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,5F0
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFA30
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+5F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+600],xmm4
       vmovdqa   xmmword ptr [rsp+rax+610],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+528]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rax,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+3B8],xmm0
       test      rax,rax
       jne       short M00_L01
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+3B8],xmm0
       jmp       short M00_L02
M00_L01:
       lea       rdx,[rax+10]
       mov       [rsp+3B0],rdx
       mov       rdx,[rsp+3B0]
       mov       [rsp+3B8],rdx
       mov       eax,[rax+8]
       mov       [rsp+3C0],eax
M00_L02:
       vmovdqu   xmm0,xmmword ptr [rsp+3B8]
       vmovdqu   xmmword ptr [rsp+518],xmm0
       xor       edi,edi
M00_L03:
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+3A0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+390],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+380],xmm0
       mov       rax,[rsp+390]
       mov       rdx,rax
       mov       ecx,[rsp+398]
       mov       r8d,ecx
       mov       [rsp+378],rdx
       mov       rdx,[rsp+378]
       mov       [rsp+380],rdx
       mov       [rsp+388],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+380]
       vmovdqu   xmmword ptr [rsp+368],xmm0
       cmp       dword ptr [rsp+370],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+368]
       vmovdqu   xmmword ptr [rsp+358],xmm0
       mov       rdx,[rsp+358]
       mov       edx,[rdx]
       lea       r8,[rsp+528]
       mov       [r8],edx
       cmp       ecx,4
       jb        near ptr M00_L07
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+348],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+338],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+328],xmm0
       mov       rdx,rax
       mov       r8d,ecx
       mov       [rsp+320],rdx
       mov       rdx,[rsp+320]
       mov       [rsp+328],rdx
       mov       [rsp+330],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+328]
       vmovdqu   xmmword ptr [rsp+310],xmm0
       cmp       dword ptr [rsp+318],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+310]
       vmovdqu   xmmword ptr [rsp+300],xmm0
       mov       rdx,[rsp+300]
       movzx     edx,word ptr [rdx]
       lea       r8,[rsp+52C]
       mov       [r8],dx
       cmp       ecx,2
       jb        near ptr M00_L07
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+2F0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+2E0],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+2D0],xmm0
       mov       rdx,rax
       mov       r8d,ecx
       mov       [rsp+2C8],rdx
       mov       rdx,[rsp+2C8]
       mov       [rsp+2D0],rdx
       mov       [rsp+2D8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+2D0]
       vmovdqu   xmmword ptr [rsp+2B8],xmm0
       cmp       dword ptr [rsp+2C0],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+2B8]
       vmovdqu   xmmword ptr [rsp+2A8],xmm0
       mov       rdx,[rsp+2A8]
       mov       edx,[rdx]
       lea       r8,[rsp+530]
       mov       [r8],edx
       cmp       ecx,4
       jb        near ptr M00_L07
       mov       rdx,rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+298],xmm0
       lea       r8d,[rcx+0FFFC]
       mov       r9d,r8d
       add       rdx,4
       mov       [rsp+290],rdx
       mov       r10,[rsp+290]
       mov       [rsp+298],r10
       mov       [rsp+2A0],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+298]
       vmovdqu   xmmword ptr [rsp+280],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+298]
       vmovdqu   xmmword ptr [rsp+270],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+260],xmm0
       mov       r9,[rsp+270]
       mov       r10d,[rsp+278]
       mov       [rsp+258],r9
       mov       r9,[rsp+258]
       mov       [rsp+260],r9
       mov       [rsp+268],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+260]
       vmovdqu   xmmword ptr [rsp+248],xmm0
       cmp       dword ptr [rsp+250],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+248]
       vmovdqu   xmmword ptr [rsp+238],xmm0
       mov       r9,[rsp+238]
       movzx     r9d,word ptr [r9]
       lea       r10,[rsp+534]
       mov       [r10],r9w
       cmp       dword ptr [rsp+288],2
       jb        near ptr M00_L07
       mov       r9,[rsp+280]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+228],xmm0
       mov       r10d,[rsp+288]
       add       r10d,0FFFFFFFE
       add       r9,2
       mov       [rsp+220],r9
       mov       r9,[rsp+220]
       mov       [rsp+228],r9
       mov       [rsp+230],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+228]
       vmovdqu   xmmword ptr [rsp+210],xmm0
       lea       r9,[rsp+536]
       cmp       dword ptr [rsp+218],0
       jbe       near ptr M00_L09
       mov       r10,[rsp+210]
       movzx     r10d,byte ptr [r10]
       mov       [r9],r10b
       cmp       dword ptr [rsp+218],1
       jb        near ptr M00_L07
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+200],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+1F0],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1E0],xmm0
       mov       r9,rax
       mov       r10d,ecx
       mov       [rsp+1D8],r9
       mov       r9,[rsp+1D8]
       mov       [rsp+1E0],r9
       mov       [rsp+1E8],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+1E0]
       vmovdqu   xmmword ptr [rsp+1C8],xmm0
       cmp       dword ptr [rsp+1D0],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+1C8]
       vmovdqu   xmmword ptr [rsp+1B8],xmm0
       mov       r9,[rsp+1B8]
       mov       r9d,[r9]
       lea       r10,[rsp+538]
       mov       [r10],r9d
       cmp       ecx,4
       jb        near ptr M00_L07
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1A8],xmm0
       mov       r9d,r8d
       mov       [rsp+1A0],rdx
       mov       r10,[rsp+1A0]
       mov       [rsp+1A8],r10
       mov       [rsp+1B0],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+1A8]
       vmovdqu   xmmword ptr [rsp+190],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+1A8]
       vmovdqu   xmmword ptr [rsp+180],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+170],xmm0
       mov       r9,[rsp+180]
       mov       r10d,[rsp+188]
       mov       [rsp+168],r9
       mov       r9,[rsp+168]
       mov       [rsp+170],r9
       mov       [rsp+178],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+170]
       vmovdqu   xmmword ptr [rsp+158],xmm0
       cmp       dword ptr [rsp+160],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+158]
       vmovdqu   xmmword ptr [rsp+148],xmm0
       mov       r9,[rsp+148]
       movzx     r9d,word ptr [r9]
       lea       r10,[rsp+53C]
       mov       [r10],r9w
       cmp       dword ptr [rsp+198],2
       jb        near ptr M00_L07
       mov       r9,[rsp+190]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+138],xmm0
       mov       r10d,[rsp+198]
       add       r10d,0FFFFFFFE
       add       r9,2
       mov       [rsp+130],r9
       mov       r9,[rsp+130]
       mov       [rsp+138],r9
       mov       [rsp+140],r10d
       vmovdqu   xmm0,xmmword ptr [rsp+138]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       lea       r9,[rsp+53E]
       cmp       dword ptr [rsp+128],0
       jbe       near ptr M00_L09
       mov       r10,[rsp+120]
       movzx     r10d,byte ptr [r10]
       mov       [r9],r10b
       cmp       dword ptr [rsp+128],1
       jb        near ptr M00_L07
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+0E0],xmm0
       xor       r9d,r9d
       mov       [rsp+0DC],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+0C8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0B8],xmm0
       mov       r9d,ecx
       mov       [rsp+0B0],rax
       mov       rax,[rsp+0B0]
       mov       [rsp+0B8],rax
       mov       [rsp+0C0],r9d
       vmovdqu   xmm0,xmmword ptr [rsp+0B8]
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       cmp       dword ptr [rsp+0A8],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+90],xmm0
       mov       rax,[rsp+90]
       mov       eax,[rax]
       lea       r9,[rsp+540]
       mov       [r9],eax
       cmp       ecx,4
       jb        near ptr M00_L07
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+80],xmm0
       mov       [rsp+78],rdx
       mov       rax,[rsp+78]
       mov       [rsp+80],rax
       mov       [rsp+88],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+80]
       vmovdqu   xmmword ptr [rsp+0F0],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0F0]
       vmovdqu   xmmword ptr [rsp+58],xmm0
       xor       eax,eax
       mov       [rsp+40],eax
       call      System.Runtime.CompilerServices.Unsafe.SizeOf[[System.UInt16, System.Private.CoreLib]]()
       cmp       eax,2
       jne       short M00_L04
       lea       rcx,[rsp+48]
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+48]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+40],ax
       lea       rbx,[rsp+544]
       lea       rcx,[rsp+40]
       call      System.Runtime.CompilerServices.Unsafe.As[[System.UInt16, System.Private.CoreLib],[System.UInt16, System.Private.CoreLib]](UInt16 ByRef)
       movzx     ecx,word ptr [rax]
       mov       [rbx],cx
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+68]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       jmp       short M00_L05
M00_L04:
       call      System.Runtime.CompilerServices.Unsafe.SizeOf[[System.UInt16, System.Private.CoreLib]]()
       cmp       eax,1
       jne       near ptr M00_L08
       lea       rbx,[rsp+544]
       cmp       dword ptr [rsp+60],0
       jbe       near ptr M00_L09
       mov       rcx,[rsp+58]
       call      System.Runtime.CompilerServices.Unsafe.As[[System.Byte, System.Private.CoreLib],[System.UInt16, System.Private.CoreLib]](Byte ByRef)
       movzx     ecx,word ptr [rax]
       mov       [rbx],cx
       lea       rcx,[rsp+58]
       lea       rdx,[rsp+68]
       mov       r8d,1
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
M00_L05:
       vmovdqu   xmm0,xmmword ptr [rsp+68]
       vmovdqu   xmmword ptr [rsp+100],xmm0
       lea       rcx,[rsp+110]
       vmovdqu   xmm0,xmmword ptr [rsp+100]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+546]
       call      Benchmarks.FullInlining.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+508]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+548]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.F, Benchmarks]](System.Span`1<Byte>, Benchmarks.F ByRef)
       lea       rcx,[rsp+4F8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+550]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       lea       rcx,[rsp+4E8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+558]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       lea       rcx,[rsp+4D8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+560]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       lea       rcx,[rsp+4C8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+568]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       lea       rcx,[rsp+4B8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+570]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       lea       rcx,[rsp+4A8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+578]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       lea       rcx,[rsp+498]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+580]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       lea       rcx,[rsp+488]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+588]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       lea       rcx,[rsp+478]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+590]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       lea       rcx,[rsp+468]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+598]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       lea       rcx,[rsp+458]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5A0]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       lea       rcx,[rsp+448]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5A8]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       lea       rcx,[rsp+438]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5B0]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       lea       rcx,[rsp+428]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5B8]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       lea       rcx,[rsp+418]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5C0]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       lea       rcx,[rsp+408]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5C8]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       lea       rcx,[rsp+3F8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5D0]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       lea       rcx,[rsp+3E8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5D8]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       lea       rcx,[rsp+3D8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5E0]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       lea       rcx,[rsp+3C8]
       vmovdqu   xmm0,xmmword ptr [rsp+518]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       lea       r8,[rsp+5E8]
       call      Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       inc       edi
       cmp       edi,44521
       jl        near ptr M00_L03
       mov       rcx,rsi
       lea       rdx,[rsp+528]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,5F0
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L06:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L07:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L08:
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.InvalidCastException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3080
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
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M07_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M07_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M07_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M07_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M08_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M08_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M08_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M08_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M09_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M09_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M09_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M09_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M10_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M10_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M10_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M10_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M11_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M11_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M11_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M11_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M12_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M12_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M12_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M12_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M13_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M13_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M13_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M13_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M14_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M14_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M14_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M14_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M15_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M15_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M15_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M15_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M16_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M16_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M16_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M16_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M17_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M17_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M17_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M17_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M18_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M18_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M18_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M18_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M19_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M19_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M19_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M19_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M20_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M20_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M20_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M20_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M21_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M21_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M21_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M21_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M22_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M22_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M22_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M22_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M23_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M23_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M23_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M23_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M24_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M24_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M24_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M24_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M25_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M25_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M25_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M25_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M26_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M26_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M26_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M26_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.FullInlining.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       sub       rsp,28
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
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M27_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M27_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M27_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M27_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
**Method was not JITted yet.**
System.Runtime.CompilerServices.Unsafe.As[[System.Byte, System.Private.CoreLib],[System.UInt16, System.Private.CoreLib]](Byte ByRef)

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_InlineFieldReads()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,298
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFD90
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+290],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+2B0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+290],rax
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+1D0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rcx,[rdi+8]
       test      rcx,rcx
       jne       short M00_L01
       xor       edi,edi
       xor       ebx,ebx
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rcx+10]
       mov       ebx,[rcx+8]
M00_L02:
       xor       ebp,ebp
M00_L03:
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
       jl        near ptr M00_L03
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
; Total bytes of code 1115
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.A, Benchmarks]](System.Span`1<Byte>, Benchmarks.A ByRef)
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
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.C ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.D, Benchmarks]](System.Span`1<Byte>, Benchmarks.D ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.D ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.E, Benchmarks]](System.Span`1<Byte>, Benchmarks.E ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.E ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.F, Benchmarks]](System.Span`1<Byte>, Benchmarks.F ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.F ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.G, Benchmarks]](System.Span`1<Byte>, Benchmarks.G ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.G ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.H, Benchmarks]](System.Span`1<Byte>, Benchmarks.H ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.H ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.I, Benchmarks]](System.Span`1<Byte>, Benchmarks.I ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.I ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.J, Benchmarks]](System.Span`1<Byte>, Benchmarks.J ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.J ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.K, Benchmarks]](System.Span`1<Byte>, Benchmarks.K ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.K ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.L, Benchmarks]](System.Span`1<Byte>, Benchmarks.L ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.L ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.M, Benchmarks]](System.Span`1<Byte>, Benchmarks.M ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.M ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.N, Benchmarks]](System.Span`1<Byte>, Benchmarks.N ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.N ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.O, Benchmarks]](System.Span`1<Byte>, Benchmarks.O ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.O ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.P, Benchmarks]](System.Span`1<Byte>, Benchmarks.P ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.P ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Q, Benchmarks]](System.Span`1<Byte>, Benchmarks.Q ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Q ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.R, Benchmarks]](System.Span`1<Byte>, Benchmarks.R ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.R ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.S, Benchmarks]](System.Span`1<Byte>, Benchmarks.S ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.S ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.T, Benchmarks]](System.Span`1<Byte>, Benchmarks.T ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.T ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.U, Benchmarks]](System.Span`1<Byte>, Benchmarks.U ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.U ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.V, Benchmarks]](System.Span`1<Byte>, Benchmarks.V ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.V ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.W, Benchmarks]](System.Span`1<Byte>, Benchmarks.W ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.W ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.X, Benchmarks]](System.Span`1<Byte>, Benchmarks.X ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.X ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Y, Benchmarks]](System.Span`1<Byte>, Benchmarks.Y ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Y ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryReadGeneric[[Benchmarks.Z, Benchmarks]](System.Span`1<Byte>, Benchmarks.Z ByRef)
       jmp       near ptr Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Z ByRef)
; Total bytes of code 5
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.C ByRef)
       sub       rsp,28
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
       lea       r9,[r8+4]
       cmp       edx,2
       jl        short M27_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M27_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M27_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M27_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.D ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M28_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M28_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M28_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M28_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.E ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M29_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M29_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M29_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M29_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.F ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M30_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M30_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M30_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M30_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.G ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M31_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M31_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M31_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M31_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.H ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M32_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M32_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M32_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M32_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.I ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M33_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M33_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M33_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M33_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.J ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M34_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M34_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M34_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M34_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.K ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M35_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M35_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M35_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M35_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.L ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M36_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M36_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M36_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M36_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.M ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M37_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M37_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M37_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M37_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.N ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M38_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M38_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M38_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M38_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.O ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M39_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M39_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M39_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M39_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.P ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M40_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M40_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M40_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M40_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Q ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M41_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M41_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M41_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M41_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.R ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M42_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M42_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M42_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M42_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.S ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M43_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M43_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M43_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M43_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.T ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M44_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M44_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M44_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M44_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.U ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M45_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M45_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M45_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M45_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.V ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M46_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M46_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M46_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M46_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.W ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M47_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M47_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M47_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M47_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.X ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M48_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M48_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M48_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M48_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Y ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M49_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M49_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M49_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M49_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
```assembly
; Benchmarks.InlineFieldReads.TryRead(System.Span`1<Byte>, Benchmarks.Z ByRef)
       sub       rsp,28
       mov       rax,[rdx]
       mov       edx,[rdx+8]
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
       jl        short M50_L00
       movzx     r10d,word ptr [rax]
       mov       [r9],r10w
       cmp       edx,2
       jb        short M50_L01
       add       edx,0FFFFFFFE
       add       rax,2
       add       r8,6
       cmp       edx,0
       jbe       short M50_L02
       movzx     r9d,byte ptr [rax]
       mov       [r8],r9b
       cmp       edx,1
       jb        short M50_L01
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 125
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_InlineStructReads()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,598
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFA90
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+590],xmm4
       vmovdqa   xmmword ptr [rsp+rax+5A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+5B0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+590],rax
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+4D0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rcx,[rdi+8]
       test      rcx,rcx
       jne       short M00_L01
       xor       edi,edi
       xor       ebx,ebx
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rcx+10]
       mov       ebx,[rcx+8]
M00_L02:
       xor       ebp,ebp
M00_L03:
       lea       rcx,[rsp+4C0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4D0]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+4B0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4D4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+490]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4D8]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+480]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+490]
       mov       [rdx],r8
       mov       r8d,[rsp+498]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4DC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+4A0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+480]
       mov       [rdx],r8
       mov       r8d,[rsp+488]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4DE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+460]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4E0]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+450]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+460]
       mov       [rdx],r8
       mov       r8d,[rsp+468]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4E4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+470]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+450]
       mov       [rdx],r8
       mov       r8d,[rsp+458]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4E6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+430]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4E8]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+420]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+430]
       mov       [rdx],r8
       mov       r8d,[rsp+438]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4EC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+440]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+420]
       mov       [rdx],r8
       mov       r8d,[rsp+428]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4EE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+400]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4F0]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+3F0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+400]
       mov       [rdx],r8
       mov       r8d,[rsp+408]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4F4]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+410]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+3F0]
       mov       [rdx],r8
       mov       r8d,[rsp+3F8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4F6]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+3D0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4F8]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+3C0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+3D0]
       mov       [rdx],r8
       mov       r8d,[rsp+3D8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4FC]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+3E0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+3C0]
       mov       [rdx],r8
       mov       r8d,[rsp+3C8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+4FE]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+3A0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+500]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+390]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+3A0]
       mov       [rdx],r8
       mov       r8d,[rsp+3A8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+504]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+3B0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+390]
       mov       [rdx],r8
       mov       r8d,[rsp+398]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+506]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+370]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+508]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+360]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+370]
       mov       [rdx],r8
       mov       r8d,[rsp+378]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+50C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+380]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+360]
       mov       [rdx],r8
       mov       r8d,[rsp+368]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+50E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+340]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+510]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+330]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+340]
       mov       [rdx],r8
       mov       r8d,[rsp+348]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+514]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+350]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+330]
       mov       [rdx],r8
       mov       r8d,[rsp+338]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+516]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+310]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+518]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+300]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+310]
       mov       [rdx],r8
       mov       r8d,[rsp+318]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+51C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+320]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+300]
       mov       [rdx],r8
       mov       r8d,[rsp+308]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+51E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+2E0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+520]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+2D0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+2E0]
       mov       [rdx],r8
       mov       r8d,[rsp+2E8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+524]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+2F0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+2D0]
       mov       [rdx],r8
       mov       r8d,[rsp+2D8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+526]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+2B0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+528]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+2A0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+2B0]
       mov       [rdx],r8
       mov       r8d,[rsp+2B8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+52C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+2C0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+2A0]
       mov       [rdx],r8
       mov       r8d,[rsp+2A8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+52E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+280]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+530]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+270]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+280]
       mov       [rdx],r8
       mov       r8d,[rsp+288]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+534]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+290]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+270]
       mov       [rdx],r8
       mov       r8d,[rsp+278]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+536]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+250]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+538]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+240]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+250]
       mov       [rdx],r8
       mov       r8d,[rsp+258]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+53C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+260]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+240]
       mov       [rdx],r8
       mov       r8d,[rsp+248]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+53E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+220]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+540]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+210]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+220]
       mov       [rdx],r8
       mov       r8d,[rsp+228]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+544]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+230]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+210]
       mov       [rdx],r8
       mov       r8d,[rsp+218]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+546]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+1F0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+548]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+1E0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+1F0]
       mov       [rdx],r8
       mov       r8d,[rsp+1F8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+54C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+200]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+1E0]
       mov       [rdx],r8
       mov       r8d,[rsp+1E8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+54E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+1C0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+550]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+1B0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+1C0]
       mov       [rdx],r8
       mov       r8d,[rsp+1C8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+554]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+1D0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+1B0]
       mov       [rdx],r8
       mov       r8d,[rsp+1B8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+556]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+190]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+558]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+180]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+190]
       mov       [rdx],r8
       mov       r8d,[rsp+198]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+55C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+1A0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+180]
       mov       [rdx],r8
       mov       r8d,[rsp+188]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+55E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+160]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+560]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+150]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+160]
       mov       [rdx],r8
       mov       r8d,[rsp+168]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+564]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+170]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+150]
       mov       [rdx],r8
       mov       r8d,[rsp+158]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+566]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+130]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+568]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+120]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+130]
       mov       [rdx],r8
       mov       r8d,[rsp+138]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+56C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+140]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+120]
       mov       [rdx],r8
       mov       r8d,[rsp+128]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+56E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+100]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+570]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+0F0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+100]
       mov       [rdx],r8
       mov       r8d,[rsp+108]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+574]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+110]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+0F0]
       mov       [rdx],r8
       mov       r8d,[rsp+0F8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+576]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+0D0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+578]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+0C0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+0D0]
       mov       [rdx],r8
       mov       r8d,[rsp+0D8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+57C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+0E0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+0C0]
       mov       [rdx],r8
       mov       r8d,[rsp+0C8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+57E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+0A0]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+580]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+90]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+0A0]
       mov       [rdx],r8
       mov       r8d,[rsp+0A8]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+584]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+0B0]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+90]
       mov       [rdx],r8
       mov       r8d,[rsp+98]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+586]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+70]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+588]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+60]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+70]
       mov       [rdx],r8
       mov       r8d,[rsp+78]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+58C]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+60]
       mov       [rdx],r8
       mov       r8d,[rsp+68]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+58E]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       [rdx],rdi
       mov       [rdx+8],ebx
       lea       rdx,[rsp+20]
       lea       r8,[rsp+590]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt32, System.Private.CoreLib]](System.Span`1<Byte>, UInt32 ByRef)
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+40]
       mov       [rdx],r8
       mov       r8d,[rsp+48]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+594]
       call      Benchmarks.InlineStructReads.ReadField[[System.UInt16, System.Private.CoreLib]](System.Span`1<Byte>, UInt16 ByRef)
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+20]
       mov       r8,[rsp+30]
       mov       [rdx],r8
       mov       r8d,[rsp+38]
       mov       [rdx+8],r8d
       lea       rdx,[rsp+20]
       lea       r8,[rsp+596]
       call      Benchmarks.InlineStructReads.ReadField[[System.Byte, System.Private.CoreLib]](System.Span`1<Byte>, Byte ByRef)
       inc       ebp
       cmp       ebp,44521
       jl        near ptr M00_L03
       mov       rcx,rsi
       lea       rdx,[rsp+4D0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,598
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 3683
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
       jl        short M02_L01
       movzx     r9d,word ptr [rax]
       mov       [r8],r9w
       cmp       edx,2
       jb        short M02_L00
       add       edx,0FFFFFFFE
       add       rax,2
       mov       [rcx],rax
       mov       [rcx+8],edx
       mov       rax,rcx
       add       rsp,28
       ret
M02_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L01:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
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

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_ManualFieldForField_Progressive()
       push      rdi
       push      rsi
       sub       rsp,0D48
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFF2E0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0D40],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D50],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D60],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0D40],rax
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+0C80]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0B00],xmm0
       test      rdx,rdx
       jne       short M00_L01
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0B00],xmm0
       jmp       short M00_L02
M00_L01:
       lea       r8,[rdx+10]
       mov       [rsp+0AF8],r8
       mov       r8,[rsp+0AF8]
       mov       [rsp+0B00],r8
       mov       edx,[rdx+8]
       mov       [rsp+0B08],edx
M00_L02:
       vmovdqu   xmm0,xmmword ptr [rsp+0B00]
       vmovdqu   xmmword ptr [rsp+0C70],xmm0
       xor       edi,edi
M00_L03:
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+0AE8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0AD8],xmm0
       mov       rdx,[rsp+0AE8]
       mov       r8d,[rsp+0AF0]
       mov       [rsp+0AD0],rdx
       mov       rdx,[rsp+0AD0]
       mov       [rsp+0AD8],rdx
       mov       [rsp+0AE0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+0AD8]
       vmovdqu   xmmword ptr [rsp+0AC0],xmm0
       cmp       dword ptr [rsp+0AC8],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+0AC0]
       vmovdqu   xmmword ptr [rsp+0AB0],xmm0
       mov       rdx,[rsp+0AB0]
       mov       edx,[rdx]
       mov       [rsp+0C80],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+0AA0],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0A90],xmm0
       mov       rdx,[rsp+0AA0]
       mov       r8d,[rsp+0AA8]
       mov       [rsp+0A88],rdx
       mov       rdx,[rsp+0A88]
       mov       [rsp+0A90],rdx
       mov       [rsp+0A98],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+0A90]
       vmovdqu   xmmword ptr [rsp+0A78],xmm0
       cmp       dword ptr [rsp+0A80],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+0A78]
       vmovdqu   xmmword ptr [rsp+0A68],xmm0
       mov       rdx,[rsp+0A68]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0C84],dx
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+0A58],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0A48],xmm0
       mov       rdx,[rsp+0A58]
       mov       r8d,[rsp+0A60]
       mov       [rsp+0A40],rdx
       mov       rdx,[rsp+0A40]
       mov       [rsp+0A48],rdx
       mov       [rsp+0A50],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+0A48]
       vmovdqu   xmmword ptr [rsp+0A30],xmm0
       cmp       dword ptr [rsp+0A38],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+0A30]
       vmovdqu   xmmword ptr [rsp+0A20],xmm0
       mov       rdx,[rsp+0A20]
       mov       edx,[rdx]
       mov       [rsp+0C88],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0A10],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+0A08],rdx
       mov       rdx,[rsp+0A08]
       mov       [rsp+0A10],rdx
       mov       [rsp+0A18],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+0A10]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+9F8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+9E8],xmm0
       mov       rdx,[rsp+9F8]
       mov       r8d,[rsp+0A00]
       mov       [rsp+9E0],rdx
       mov       rdx,[rsp+9E0]
       mov       [rsp+9E8],rdx
       mov       [rsp+9F0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+9E8]
       vmovdqu   xmmword ptr [rsp+9D0],xmm0
       cmp       dword ptr [rsp+9D8],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+9D0]
       vmovdqu   xmmword ptr [rsp+9C0],xmm0
       mov       rdx,[rsp+9C0]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0C8C],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+9B0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+9A8],rdx
       mov       rdx,[rsp+9A8]
       mov       [rsp+9B0],rdx
       mov       [rsp+9B8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+9B0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0C8E],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+998],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+988],xmm0
       mov       rdx,[rsp+998]
       mov       r8d,[rsp+9A0]
       mov       [rsp+980],rdx
       mov       rdx,[rsp+980]
       mov       [rsp+988],rdx
       mov       [rsp+990],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+988]
       vmovdqu   xmmword ptr [rsp+970],xmm0
       cmp       dword ptr [rsp+978],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+970]
       vmovdqu   xmmword ptr [rsp+960],xmm0
       mov       rdx,[rsp+960]
       mov       edx,[rdx]
       mov       [rsp+0C90],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+950],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+948],rdx
       mov       rdx,[rsp+948]
       mov       [rsp+950],rdx
       mov       [rsp+958],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+950]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+938],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+928],xmm0
       mov       rdx,[rsp+938]
       mov       r8d,[rsp+940]
       mov       [rsp+920],rdx
       mov       rdx,[rsp+920]
       mov       [rsp+928],rdx
       mov       [rsp+930],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+928]
       vmovdqu   xmmword ptr [rsp+910],xmm0
       cmp       dword ptr [rsp+918],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+910]
       vmovdqu   xmmword ptr [rsp+900],xmm0
       mov       rdx,[rsp+900]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0C94],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+8F0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+8E8],rdx
       mov       rdx,[rsp+8E8]
       mov       [rsp+8F0],rdx
       mov       [rsp+8F8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+8F0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0C96],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+8D8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+8C8],xmm0
       mov       rdx,[rsp+8D8]
       mov       r8d,[rsp+8E0]
       mov       [rsp+8C0],rdx
       mov       rdx,[rsp+8C0]
       mov       [rsp+8C8],rdx
       mov       [rsp+8D0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+8C8]
       vmovdqu   xmmword ptr [rsp+8B0],xmm0
       cmp       dword ptr [rsp+8B8],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+8B0]
       vmovdqu   xmmword ptr [rsp+8A0],xmm0
       mov       rdx,[rsp+8A0]
       mov       edx,[rdx]
       mov       [rsp+0C98],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+890],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+888],rdx
       mov       rdx,[rsp+888]
       mov       [rsp+890],rdx
       mov       [rsp+898],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+890]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+878],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+868],xmm0
       mov       rdx,[rsp+878]
       mov       r8d,[rsp+880]
       mov       [rsp+860],rdx
       mov       rdx,[rsp+860]
       mov       [rsp+868],rdx
       mov       [rsp+870],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+868]
       vmovdqu   xmmword ptr [rsp+850],xmm0
       cmp       dword ptr [rsp+858],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+850]
       vmovdqu   xmmword ptr [rsp+840],xmm0
       mov       rdx,[rsp+840]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0C9C],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+830],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+828],rdx
       mov       rdx,[rsp+828]
       mov       [rsp+830],rdx
       mov       [rsp+838],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+830]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0C9E],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+818],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+808],xmm0
       mov       rdx,[rsp+818]
       mov       r8d,[rsp+820]
       mov       [rsp+800],rdx
       mov       rdx,[rsp+800]
       mov       [rsp+808],rdx
       mov       [rsp+810],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+808]
       vmovdqu   xmmword ptr [rsp+7F0],xmm0
       cmp       dword ptr [rsp+7F8],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+7F0]
       vmovdqu   xmmword ptr [rsp+7E0],xmm0
       mov       rdx,[rsp+7E0]
       mov       edx,[rdx]
       mov       [rsp+0CA0],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+7D0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+7C8],rdx
       mov       rdx,[rsp+7C8]
       mov       [rsp+7D0],rdx
       mov       [rsp+7D8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+7D0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+7B8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+7A8],xmm0
       mov       rdx,[rsp+7B8]
       mov       r8d,[rsp+7C0]
       mov       [rsp+7A0],rdx
       mov       rdx,[rsp+7A0]
       mov       [rsp+7A8],rdx
       mov       [rsp+7B0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+7A8]
       vmovdqu   xmmword ptr [rsp+790],xmm0
       cmp       dword ptr [rsp+798],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+790]
       vmovdqu   xmmword ptr [rsp+780],xmm0
       mov       rdx,[rsp+780]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CA4],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+770],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+768],rdx
       mov       rdx,[rsp+768]
       mov       [rsp+770],rdx
       mov       [rsp+778],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+770]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CA6],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+758],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+748],xmm0
       mov       rdx,[rsp+758]
       mov       r8d,[rsp+760]
       mov       [rsp+740],rdx
       mov       rdx,[rsp+740]
       mov       [rsp+748],rdx
       mov       [rsp+750],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+748]
       vmovdqu   xmmword ptr [rsp+730],xmm0
       cmp       dword ptr [rsp+738],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+730]
       vmovdqu   xmmword ptr [rsp+720],xmm0
       mov       rdx,[rsp+720]
       mov       edx,[rdx]
       mov       [rsp+0CA8],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+710],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+708],rdx
       mov       rdx,[rsp+708]
       mov       [rsp+710],rdx
       mov       [rsp+718],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+710]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+6F8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+6E8],xmm0
       mov       rdx,[rsp+6F8]
       mov       r8d,[rsp+700]
       mov       [rsp+6E0],rdx
       mov       rdx,[rsp+6E0]
       mov       [rsp+6E8],rdx
       mov       [rsp+6F0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+6E8]
       vmovdqu   xmmword ptr [rsp+6D0],xmm0
       cmp       dword ptr [rsp+6D8],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+6D0]
       vmovdqu   xmmword ptr [rsp+6C0],xmm0
       mov       rdx,[rsp+6C0]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CAC],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+6B0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+6A8],rdx
       mov       rdx,[rsp+6A8]
       mov       [rsp+6B0],rdx
       mov       [rsp+6B8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+6B0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CAE],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+698],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+688],xmm0
       mov       rdx,[rsp+698]
       mov       r8d,[rsp+6A0]
       mov       [rsp+680],rdx
       mov       rdx,[rsp+680]
       mov       [rsp+688],rdx
       mov       [rsp+690],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+688]
       vmovdqu   xmmword ptr [rsp+670],xmm0
       cmp       dword ptr [rsp+678],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+670]
       vmovdqu   xmmword ptr [rsp+660],xmm0
       mov       rdx,[rsp+660]
       mov       edx,[rdx]
       mov       [rsp+0CB0],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+650],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+648],rdx
       mov       rdx,[rsp+648]
       mov       [rsp+650],rdx
       mov       [rsp+658],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+650]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+638],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+628],xmm0
       mov       rdx,[rsp+638]
       mov       r8d,[rsp+640]
       mov       [rsp+620],rdx
       mov       rdx,[rsp+620]
       mov       [rsp+628],rdx
       mov       [rsp+630],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+628]
       vmovdqu   xmmword ptr [rsp+610],xmm0
       cmp       dword ptr [rsp+618],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+610]
       vmovdqu   xmmword ptr [rsp+600],xmm0
       mov       rdx,[rsp+600]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CB4],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+5F0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+5E8],rdx
       mov       rdx,[rsp+5E8]
       mov       [rsp+5F0],rdx
       mov       [rsp+5F8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+5F0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CB6],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+5D8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+5C8],xmm0
       mov       rdx,[rsp+5D8]
       mov       r8d,[rsp+5E0]
       mov       [rsp+5C0],rdx
       mov       rdx,[rsp+5C0]
       mov       [rsp+5C8],rdx
       mov       [rsp+5D0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+5C8]
       vmovdqu   xmmword ptr [rsp+5B0],xmm0
       cmp       dword ptr [rsp+5B8],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+5B0]
       vmovdqu   xmmword ptr [rsp+5A0],xmm0
       mov       rdx,[rsp+5A0]
       mov       edx,[rdx]
       mov       [rsp+0CB8],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+590],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+588],rdx
       mov       rdx,[rsp+588]
       mov       [rsp+590],rdx
       mov       [rsp+598],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+590]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+578],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+568],xmm0
       mov       rdx,[rsp+578]
       mov       r8d,[rsp+580]
       mov       [rsp+560],rdx
       mov       rdx,[rsp+560]
       mov       [rsp+568],rdx
       mov       [rsp+570],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+568]
       vmovdqu   xmmword ptr [rsp+550],xmm0
       cmp       dword ptr [rsp+558],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+550]
       vmovdqu   xmmword ptr [rsp+540],xmm0
       mov       rdx,[rsp+540]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CBC],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+530],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+528],rdx
       mov       rdx,[rsp+528]
       mov       [rsp+530],rdx
       mov       [rsp+538],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+530]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CBE],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+518],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+508],xmm0
       mov       rdx,[rsp+518]
       mov       r8d,[rsp+520]
       mov       [rsp+500],rdx
       mov       rdx,[rsp+500]
       mov       [rsp+508],rdx
       mov       [rsp+510],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+508]
       vmovdqu   xmmword ptr [rsp+4F0],xmm0
       cmp       dword ptr [rsp+4F8],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+4F0]
       vmovdqu   xmmword ptr [rsp+4E0],xmm0
       mov       rdx,[rsp+4E0]
       mov       edx,[rdx]
       mov       [rsp+0CC0],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+4D0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+4C8],rdx
       mov       rdx,[rsp+4C8]
       mov       [rsp+4D0],rdx
       mov       [rsp+4D8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+4D0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+4B8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+4A8],xmm0
       mov       rdx,[rsp+4B8]
       mov       r8d,[rsp+4C0]
       mov       [rsp+4A0],rdx
       mov       rdx,[rsp+4A0]
       mov       [rsp+4A8],rdx
       mov       [rsp+4B0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+4A8]
       vmovdqu   xmmword ptr [rsp+490],xmm0
       cmp       dword ptr [rsp+498],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+490]
       vmovdqu   xmmword ptr [rsp+480],xmm0
       mov       rdx,[rsp+480]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CC4],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+470],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+468],rdx
       mov       rdx,[rsp+468]
       mov       [rsp+470],rdx
       mov       [rsp+478],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+470]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CC6],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+458],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+448],xmm0
       mov       rdx,[rsp+458]
       mov       r8d,[rsp+460]
       mov       [rsp+440],rdx
       mov       rdx,[rsp+440]
       mov       [rsp+448],rdx
       mov       [rsp+450],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+448]
       vmovdqu   xmmword ptr [rsp+430],xmm0
       cmp       dword ptr [rsp+438],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+430]
       vmovdqu   xmmword ptr [rsp+420],xmm0
       mov       rdx,[rsp+420]
       mov       edx,[rdx]
       mov       [rsp+0CC8],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+410],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+408],rdx
       mov       rdx,[rsp+408]
       mov       [rsp+410],rdx
       mov       [rsp+418],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+410]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+3F8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+3E8],xmm0
       mov       rdx,[rsp+3F8]
       mov       r8d,[rsp+400]
       mov       [rsp+3E0],rdx
       mov       rdx,[rsp+3E0]
       mov       [rsp+3E8],rdx
       mov       [rsp+3F0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+3E8]
       vmovdqu   xmmword ptr [rsp+3D0],xmm0
       cmp       dword ptr [rsp+3D8],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+3D0]
       vmovdqu   xmmword ptr [rsp+3C0],xmm0
       mov       rdx,[rsp+3C0]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CCC],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+3B0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+3A8],rdx
       mov       rdx,[rsp+3A8]
       mov       [rsp+3B0],rdx
       mov       [rsp+3B8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+3B0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CCE],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+398],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+388],xmm0
       mov       rdx,[rsp+398]
       mov       r8d,[rsp+3A0]
       mov       [rsp+380],rdx
       mov       rdx,[rsp+380]
       mov       [rsp+388],rdx
       mov       [rsp+390],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+388]
       vmovdqu   xmmword ptr [rsp+370],xmm0
       cmp       dword ptr [rsp+378],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+370]
       vmovdqu   xmmword ptr [rsp+360],xmm0
       mov       rdx,[rsp+360]
       mov       edx,[rdx]
       mov       [rsp+0CD0],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+350],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+348],rdx
       mov       rdx,[rsp+348]
       mov       [rsp+350],rdx
       mov       [rsp+358],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+350]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+338],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+328],xmm0
       mov       rdx,[rsp+338]
       mov       r8d,[rsp+340]
       mov       [rsp+320],rdx
       mov       rdx,[rsp+320]
       mov       [rsp+328],rdx
       mov       [rsp+330],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+328]
       vmovdqu   xmmword ptr [rsp+310],xmm0
       cmp       dword ptr [rsp+318],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+310]
       vmovdqu   xmmword ptr [rsp+300],xmm0
       mov       rdx,[rsp+300]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CD4],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+2F0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+2E8],rdx
       mov       rdx,[rsp+2E8]
       mov       [rsp+2F0],rdx
       mov       [rsp+2F8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+2F0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CD6],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+2D8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+2C8],xmm0
       mov       rdx,[rsp+2D8]
       mov       r8d,[rsp+2E0]
       mov       [rsp+2C0],rdx
       mov       rdx,[rsp+2C0]
       mov       [rsp+2C8],rdx
       mov       [rsp+2D0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+2C8]
       vmovdqu   xmmword ptr [rsp+2B0],xmm0
       cmp       dword ptr [rsp+2B8],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+2B0]
       vmovdqu   xmmword ptr [rsp+2A0],xmm0
       mov       rdx,[rsp+2A0]
       mov       edx,[rdx]
       mov       [rsp+0CD8],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+290],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+288],rdx
       mov       rdx,[rsp+288]
       mov       [rsp+290],rdx
       mov       [rsp+298],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+290]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+278],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+268],xmm0
       mov       rdx,[rsp+278]
       mov       r8d,[rsp+280]
       mov       [rsp+260],rdx
       mov       rdx,[rsp+260]
       mov       [rsp+268],rdx
       mov       [rsp+270],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+268]
       vmovdqu   xmmword ptr [rsp+250],xmm0
       cmp       dword ptr [rsp+258],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+250]
       vmovdqu   xmmword ptr [rsp+240],xmm0
       mov       rdx,[rsp+240]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CDC],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+230],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+228],rdx
       mov       rdx,[rsp+228]
       mov       [rsp+230],rdx
       mov       [rsp+238],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+230]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CDE],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+218],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+208],xmm0
       mov       rdx,[rsp+218]
       mov       r8d,[rsp+220]
       mov       [rsp+200],rdx
       mov       rdx,[rsp+200]
       mov       [rsp+208],rdx
       mov       [rsp+210],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+208]
       vmovdqu   xmmword ptr [rsp+1F0],xmm0
       cmp       dword ptr [rsp+1F8],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+1F0]
       vmovdqu   xmmword ptr [rsp+1E0],xmm0
       mov       rdx,[rsp+1E0]
       mov       edx,[rdx]
       mov       [rsp+0CE0],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1D0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+1C8],rdx
       mov       rdx,[rsp+1C8]
       mov       [rsp+1D0],rdx
       mov       [rsp+1D8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+1D0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+1B8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1A8],xmm0
       mov       rdx,[rsp+1B8]
       mov       r8d,[rsp+1C0]
       mov       [rsp+1A0],rdx
       mov       rdx,[rsp+1A0]
       mov       [rsp+1A8],rdx
       mov       [rsp+1B0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+1A8]
       vmovdqu   xmmword ptr [rsp+190],xmm0
       cmp       dword ptr [rsp+198],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+190]
       vmovdqu   xmmword ptr [rsp+180],xmm0
       mov       rdx,[rsp+180]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CE4],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+170],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+168],rdx
       mov       rdx,[rsp+168]
       mov       [rsp+170],rdx
       mov       [rsp+178],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+170]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CE6],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+158],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+148],xmm0
       mov       rdx,[rsp+158]
       mov       r8d,[rsp+160]
       mov       [rsp+140],rdx
       mov       rdx,[rsp+140]
       mov       [rsp+148],rdx
       mov       [rsp+150],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+148]
       vmovdqu   xmmword ptr [rsp+130],xmm0
       cmp       dword ptr [rsp+138],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+130]
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       rdx,[rsp+120]
       mov       edx,[rdx]
       mov       [rsp+0CE8],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+110],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       add       rdx,4
       mov       [rsp+108],rdx
       mov       rdx,[rsp+108]
       mov       [rsp+110],rdx
       mov       [rsp+118],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+110]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+0F8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0E8],xmm0
       mov       rdx,[rsp+0F8]
       mov       r8d,[rsp+100]
       mov       [rsp+0E0],rdx
       mov       rdx,[rsp+0E0]
       mov       [rsp+0E8],rdx
       mov       [rsp+0F0],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+0E8]
       vmovdqu   xmmword ptr [rsp+0D0],xmm0
       cmp       dword ptr [rsp+0D8],2
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+0D0]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       rdx,[rsp+0C0]
       movzx     edx,word ptr [rdx]
       mov       [rsp+0CEC],dx
       cmp       dword ptr [rsp+0C68],2
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0B0],xmm0
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       add       rdx,2
       mov       [rsp+0A8],rdx
       mov       rdx,[rsp+0A8]
       mov       [rsp+0B0],rdx
       mov       [rsp+0B8],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+0B0]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0CEE],dl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+88],xmm0
       mov       rdx,[rsp+98]
       mov       r8d,[rsp+0A0]
       mov       [rsp+80],rdx
       mov       rdx,[rsp+80]
       mov       [rsp+88],rdx
       mov       [rsp+90],r8d
       vmovdqu   xmm0,xmmword ptr [rsp+88]
       vmovdqu   xmmword ptr [rsp+70],xmm0
       cmp       dword ptr [rsp+78],4
       jl        near ptr M00_L05
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       mov       rdx,[rsp+60]
       mov       edx,[rdx]
       mov       [rsp+0CF0],edx
       cmp       dword ptr [rsp+0C68],4
       jb        near ptr M00_L06
       mov       rdx,[rsp+0C60]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       add       rdx,4
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFC
       lea       rcx,[rsp+50]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0C50]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C50]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0CF4],ax
       cmp       dword ptr [rsp+0C68],2
       jae       short M00_L04
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
M00_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rsp+0C60]
       mov       edx,2
       call      Internal.Runtime.CompilerServices.Unsafe.Add[[System.Byte, System.Private.CoreLib]](Byte ByRef, Int32)
       mov       rdx,rax
       mov       r8d,[rsp+0C68]
       add       r8d,0FFFFFFFE
       lea       rcx,[rsp+40]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rsp+40]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0CF6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0C40]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C40]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0CF8],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0C30]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C30]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0CFC],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0CFE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0C20]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C20]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D00],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0C10]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C10]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D04],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0D06],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0C00]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C00]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D08],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0BF0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BF0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D0C],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0D0E],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0BE0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BE0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D10],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0BD0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BD0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D14],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0D16],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0BC0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BC0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D18],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0BB0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BB0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D1C],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0D1E],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0BA0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BA0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D20],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0B90]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B90]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D24],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0D26],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0B80]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B80]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D28],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0B70]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B70]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D2C],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0D2E],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0B60]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B60]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D30],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0B50]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B50]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D34],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0D36],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0B40]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B40]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D38],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0B30]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B30]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D3C],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C60]
       movzx     ecx,byte ptr [rcx]
       mov       [rsp+0D3E],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0B20]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B20]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D40],eax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0B10]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B10]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D44],ax
       lea       rcx,[rsp+0C60]
       lea       rdx,[rsp+0C60]
       mov       r8d,2
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       cmp       dword ptr [rsp+0C68],0
       jbe       short M00_L07
       mov       rdx,[rsp+0C60]
       movzx     edx,byte ptr [rdx]
       mov       [rsp+0D46],dl
       inc       edi
       cmp       edi,44521
       jl        near ptr M00_L03
       mov       rcx,rsi
       lea       rdx,[rsp+0C80]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,0D48
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
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 10402
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
; Internal.Runtime.CompilerServices.Unsafe.Add[[System.Byte, System.Private.CoreLib]](Byte ByRef, Int32)
       movsxd    rax,edx
       add       rax,rcx
       ret
; Total bytes of code 7
```
```assembly
; System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       sub       rsp,28
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       cmp       ecx,4
       jl        short M05_L00
       mov       eax,[rax]
       add       rsp,28
       ret
M05_L00:
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
       ja        short M06_L00
       mov       rcx,[rcx]
       sub       eax,r8d
       movsxd    r8,r8d
       add       rcx,r8
       mov       [rdx],rcx
       mov       [rdx+8],eax
       mov       rax,rdx
       add       rsp,28
       ret
M06_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException()

## .NET Core 5.0.0 (CoreCLR 5.0.20.27801, CoreFX 5.0.20.27801), X64 RyuJIT
```assembly
; Benchmarks.Benchmarks.FromSpan_ManualFieldForField_NoProgress()
       push      rdi
       push      rsi
       sub       rsp,0D68
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFF2E0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+0D60],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D70],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0D80],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+0D60],rax
       mov       rdi,rcx
       mov       rsi,rdx
       xor       edx,edx
       lea       rcx,[rsp+0CA0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMSET
       mov       rcx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0AC0],xmm0
       test      rcx,rcx
       jne       short M00_L01
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0AC0],xmm0
       jmp       short M00_L02
M00_L01:
       lea       rdx,[rcx+10]
       mov       [rsp+0AB8],rdx
       mov       rdx,[rsp+0AB8]
       mov       [rsp+0AC0],rdx
       mov       ecx,[rcx+8]
       mov       [rsp+0AC8],ecx
M00_L02:
       vmovdqu   xmm0,xmmword ptr [rsp+0AC0]
       vmovdqu   xmmword ptr [rsp+0C90],xmm0
       xor       edi,edi
M00_L03:
       vmovdqu   xmm0,xmmword ptr [rsp+0C90]
       vmovdqu   xmmword ptr [rsp+0C80],xmm0
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+0AA8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0A98],xmm0
       mov       rcx,[rsp+0AA8]
       mov       edx,[rsp+0AB0]
       mov       [rsp+0A90],rcx
       mov       rcx,[rsp+0A90]
       mov       [rsp+0A98],rcx
       mov       [rsp+0AA0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0A98]
       vmovdqu   xmmword ptr [rsp+0A80],xmm0
       cmp       dword ptr [rsp+0A88],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+0A80]
       vmovdqu   xmmword ptr [rsp+0A70],xmm0
       mov       rcx,[rsp+0A70]
       mov       ecx,[rcx]
       mov       [rsp+0CA0],ecx
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+0A60],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0A50],xmm0
       mov       rcx,[rsp+0A60]
       mov       edx,[rsp+0A68]
       mov       [rsp+0A48],rcx
       mov       rcx,[rsp+0A48]
       mov       [rsp+0A50],rcx
       mov       [rsp+0A58],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0A50]
       vmovdqu   xmmword ptr [rsp+0A38],xmm0
       cmp       dword ptr [rsp+0A40],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+0A38]
       vmovdqu   xmmword ptr [rsp+0A28],xmm0
       mov       rcx,[rsp+0A28]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CA4],cx
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+0A18],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0A08],xmm0
       mov       rcx,[rsp+0A18]
       mov       edx,[rsp+0A20]
       mov       [rsp+0A00],rcx
       mov       rcx,[rsp+0A00]
       mov       [rsp+0A08],rcx
       mov       [rsp+0A10],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0A08]
       vmovdqu   xmmword ptr [rsp+9F0],xmm0
       cmp       dword ptr [rsp+9F8],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+9F0]
       vmovdqu   xmmword ptr [rsp+9E0],xmm0
       mov       rcx,[rsp+9E0]
       mov       ecx,[rcx]
       mov       [rsp+0CA8],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+9D0],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+9C8],rcx
       mov       rcx,[rsp+9C8]
       mov       [rsp+9D0],rcx
       mov       [rsp+9D8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+9D0]
       vmovdqu   xmmword ptr [rsp+9B8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+9A8],xmm0
       mov       rcx,[rsp+9B8]
       mov       edx,[rsp+9C0]
       mov       [rsp+9A0],rcx
       mov       rcx,[rsp+9A0]
       mov       [rsp+9A8],rcx
       mov       [rsp+9B0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+9A8]
       vmovdqu   xmmword ptr [rsp+990],xmm0
       cmp       dword ptr [rsp+998],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+990]
       vmovdqu   xmmword ptr [rsp+980],xmm0
       mov       rcx,[rsp+980]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CAC],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CAE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+970],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+960],xmm0
       mov       rcx,[rsp+970]
       mov       edx,[rsp+978]
       mov       [rsp+958],rcx
       mov       rcx,[rsp+958]
       mov       [rsp+960],rcx
       mov       [rsp+968],edx
       vmovdqu   xmm0,xmmword ptr [rsp+960]
       vmovdqu   xmmword ptr [rsp+948],xmm0
       cmp       dword ptr [rsp+950],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+948]
       vmovdqu   xmmword ptr [rsp+938],xmm0
       mov       rcx,[rsp+938]
       mov       ecx,[rcx]
       mov       [rsp+0CB0],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+928],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+920],rcx
       mov       rcx,[rsp+920]
       mov       [rsp+928],rcx
       mov       [rsp+930],edx
       vmovdqu   xmm0,xmmword ptr [rsp+928]
       vmovdqu   xmmword ptr [rsp+910],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+900],xmm0
       mov       rcx,[rsp+910]
       mov       edx,[rsp+918]
       mov       [rsp+8F8],rcx
       mov       rcx,[rsp+8F8]
       mov       [rsp+900],rcx
       mov       [rsp+908],edx
       vmovdqu   xmm0,xmmword ptr [rsp+900]
       vmovdqu   xmmword ptr [rsp+8E8],xmm0
       cmp       dword ptr [rsp+8F0],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+8E8]
       vmovdqu   xmmword ptr [rsp+8D8],xmm0
       mov       rcx,[rsp+8D8]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CB4],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CB6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+8C8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+8B8],xmm0
       mov       rcx,[rsp+8C8]
       mov       edx,[rsp+8D0]
       mov       [rsp+8B0],rcx
       mov       rcx,[rsp+8B0]
       mov       [rsp+8B8],rcx
       mov       [rsp+8C0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+8B8]
       vmovdqu   xmmword ptr [rsp+8A0],xmm0
       cmp       dword ptr [rsp+8A8],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+8A0]
       vmovdqu   xmmword ptr [rsp+890],xmm0
       mov       rcx,[rsp+890]
       mov       ecx,[rcx]
       mov       [rsp+0CB8],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+880],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+878],rcx
       mov       rcx,[rsp+878]
       mov       [rsp+880],rcx
       mov       [rsp+888],edx
       vmovdqu   xmm0,xmmword ptr [rsp+880]
       vmovdqu   xmmword ptr [rsp+868],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+858],xmm0
       mov       rcx,[rsp+868]
       mov       edx,[rsp+870]
       mov       [rsp+850],rcx
       mov       rcx,[rsp+850]
       mov       [rsp+858],rcx
       mov       [rsp+860],edx
       vmovdqu   xmm0,xmmword ptr [rsp+858]
       vmovdqu   xmmword ptr [rsp+840],xmm0
       cmp       dword ptr [rsp+848],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+840]
       vmovdqu   xmmword ptr [rsp+830],xmm0
       mov       rcx,[rsp+830]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CBC],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CBE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+820],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+810],xmm0
       mov       rcx,[rsp+820]
       mov       edx,[rsp+828]
       mov       [rsp+808],rcx
       mov       rcx,[rsp+808]
       mov       [rsp+810],rcx
       mov       [rsp+818],edx
       vmovdqu   xmm0,xmmword ptr [rsp+810]
       vmovdqu   xmmword ptr [rsp+7F8],xmm0
       cmp       dword ptr [rsp+800],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+7F8]
       vmovdqu   xmmword ptr [rsp+7E8],xmm0
       mov       rcx,[rsp+7E8]
       mov       ecx,[rcx]
       mov       [rsp+0CC0],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+7D8],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+7D0],rcx
       mov       rcx,[rsp+7D0]
       mov       [rsp+7D8],rcx
       mov       [rsp+7E0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+7D8]
       vmovdqu   xmmword ptr [rsp+7C0],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+7B0],xmm0
       mov       rcx,[rsp+7C0]
       mov       edx,[rsp+7C8]
       mov       [rsp+7A8],rcx
       mov       rcx,[rsp+7A8]
       mov       [rsp+7B0],rcx
       mov       [rsp+7B8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+7B0]
       vmovdqu   xmmword ptr [rsp+798],xmm0
       cmp       dword ptr [rsp+7A0],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+798]
       vmovdqu   xmmword ptr [rsp+788],xmm0
       mov       rcx,[rsp+788]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CC4],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CC6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+778],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+768],xmm0
       mov       rcx,[rsp+778]
       mov       edx,[rsp+780]
       mov       [rsp+760],rcx
       mov       rcx,[rsp+760]
       mov       [rsp+768],rcx
       mov       [rsp+770],edx
       vmovdqu   xmm0,xmmword ptr [rsp+768]
       vmovdqu   xmmword ptr [rsp+750],xmm0
       cmp       dword ptr [rsp+758],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+750]
       vmovdqu   xmmword ptr [rsp+740],xmm0
       mov       rcx,[rsp+740]
       mov       ecx,[rcx]
       mov       [rsp+0CC8],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+730],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+728],rcx
       mov       rcx,[rsp+728]
       mov       [rsp+730],rcx
       mov       [rsp+738],edx
       vmovdqu   xmm0,xmmword ptr [rsp+730]
       vmovdqu   xmmword ptr [rsp+718],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+708],xmm0
       mov       rcx,[rsp+718]
       mov       edx,[rsp+720]
       mov       [rsp+700],rcx
       mov       rcx,[rsp+700]
       mov       [rsp+708],rcx
       mov       [rsp+710],edx
       vmovdqu   xmm0,xmmword ptr [rsp+708]
       vmovdqu   xmmword ptr [rsp+6F0],xmm0
       cmp       dword ptr [rsp+6F8],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+6F0]
       vmovdqu   xmmword ptr [rsp+6E0],xmm0
       mov       rcx,[rsp+6E0]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CCC],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CCE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+6D0],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+6C0],xmm0
       mov       rcx,[rsp+6D0]
       mov       edx,[rsp+6D8]
       mov       [rsp+6B8],rcx
       mov       rcx,[rsp+6B8]
       mov       [rsp+6C0],rcx
       mov       [rsp+6C8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+6C0]
       vmovdqu   xmmword ptr [rsp+6A8],xmm0
       cmp       dword ptr [rsp+6B0],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+6A8]
       vmovdqu   xmmword ptr [rsp+698],xmm0
       mov       rcx,[rsp+698]
       mov       ecx,[rcx]
       mov       [rsp+0CD0],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+688],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+680],rcx
       mov       rcx,[rsp+680]
       mov       [rsp+688],rcx
       mov       [rsp+690],edx
       vmovdqu   xmm0,xmmword ptr [rsp+688]
       vmovdqu   xmmword ptr [rsp+670],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+660],xmm0
       mov       rcx,[rsp+670]
       mov       edx,[rsp+678]
       mov       [rsp+658],rcx
       mov       rcx,[rsp+658]
       mov       [rsp+660],rcx
       mov       [rsp+668],edx
       vmovdqu   xmm0,xmmword ptr [rsp+660]
       vmovdqu   xmmword ptr [rsp+648],xmm0
       cmp       dword ptr [rsp+650],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+648]
       vmovdqu   xmmword ptr [rsp+638],xmm0
       mov       rcx,[rsp+638]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CD4],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CD6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+628],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+618],xmm0
       mov       rcx,[rsp+628]
       mov       edx,[rsp+630]
       mov       [rsp+610],rcx
       mov       rcx,[rsp+610]
       mov       [rsp+618],rcx
       mov       [rsp+620],edx
       vmovdqu   xmm0,xmmword ptr [rsp+618]
       vmovdqu   xmmword ptr [rsp+600],xmm0
       cmp       dword ptr [rsp+608],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+600]
       vmovdqu   xmmword ptr [rsp+5F0],xmm0
       mov       rcx,[rsp+5F0]
       mov       ecx,[rcx]
       mov       [rsp+0CD8],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+5E0],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+5D8],rcx
       mov       rcx,[rsp+5D8]
       mov       [rsp+5E0],rcx
       mov       [rsp+5E8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+5E0]
       vmovdqu   xmmword ptr [rsp+5C8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+5B8],xmm0
       mov       rcx,[rsp+5C8]
       mov       edx,[rsp+5D0]
       mov       [rsp+5B0],rcx
       mov       rcx,[rsp+5B0]
       mov       [rsp+5B8],rcx
       mov       [rsp+5C0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+5B8]
       vmovdqu   xmmword ptr [rsp+5A0],xmm0
       cmp       dword ptr [rsp+5A8],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+5A0]
       vmovdqu   xmmword ptr [rsp+590],xmm0
       mov       rcx,[rsp+590]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CDC],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CDE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+580],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+570],xmm0
       mov       rcx,[rsp+580]
       mov       edx,[rsp+588]
       mov       [rsp+568],rcx
       mov       rcx,[rsp+568]
       mov       [rsp+570],rcx
       mov       [rsp+578],edx
       vmovdqu   xmm0,xmmword ptr [rsp+570]
       vmovdqu   xmmword ptr [rsp+558],xmm0
       cmp       dword ptr [rsp+560],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+558]
       vmovdqu   xmmword ptr [rsp+548],xmm0
       mov       rcx,[rsp+548]
       mov       ecx,[rcx]
       mov       [rsp+0CE0],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+538],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+530],rcx
       mov       rcx,[rsp+530]
       mov       [rsp+538],rcx
       mov       [rsp+540],edx
       vmovdqu   xmm0,xmmword ptr [rsp+538]
       vmovdqu   xmmword ptr [rsp+520],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+510],xmm0
       mov       rcx,[rsp+520]
       mov       edx,[rsp+528]
       mov       [rsp+508],rcx
       mov       rcx,[rsp+508]
       mov       [rsp+510],rcx
       mov       [rsp+518],edx
       vmovdqu   xmm0,xmmword ptr [rsp+510]
       vmovdqu   xmmword ptr [rsp+4F8],xmm0
       cmp       dword ptr [rsp+500],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+4F8]
       vmovdqu   xmmword ptr [rsp+4E8],xmm0
       mov       rcx,[rsp+4E8]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CE4],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CE6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+4D8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+4C8],xmm0
       mov       rcx,[rsp+4D8]
       mov       edx,[rsp+4E0]
       mov       [rsp+4C0],rcx
       mov       rcx,[rsp+4C0]
       mov       [rsp+4C8],rcx
       mov       [rsp+4D0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+4C8]
       vmovdqu   xmmword ptr [rsp+4B0],xmm0
       cmp       dword ptr [rsp+4B8],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+4B0]
       vmovdqu   xmmword ptr [rsp+4A0],xmm0
       mov       rcx,[rsp+4A0]
       mov       ecx,[rcx]
       mov       [rsp+0CE8],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+490],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+488],rcx
       mov       rcx,[rsp+488]
       mov       [rsp+490],rcx
       mov       [rsp+498],edx
       vmovdqu   xmm0,xmmword ptr [rsp+490]
       vmovdqu   xmmword ptr [rsp+478],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+468],xmm0
       mov       rcx,[rsp+478]
       mov       edx,[rsp+480]
       mov       [rsp+460],rcx
       mov       rcx,[rsp+460]
       mov       [rsp+468],rcx
       mov       [rsp+470],edx
       vmovdqu   xmm0,xmmword ptr [rsp+468]
       vmovdqu   xmmword ptr [rsp+450],xmm0
       cmp       dword ptr [rsp+458],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+450]
       vmovdqu   xmmword ptr [rsp+440],xmm0
       mov       rcx,[rsp+440]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CEC],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CEE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+430],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+420],xmm0
       mov       rcx,[rsp+430]
       mov       edx,[rsp+438]
       mov       [rsp+418],rcx
       mov       rcx,[rsp+418]
       mov       [rsp+420],rcx
       mov       [rsp+428],edx
       vmovdqu   xmm0,xmmword ptr [rsp+420]
       vmovdqu   xmmword ptr [rsp+408],xmm0
       cmp       dword ptr [rsp+410],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+408]
       vmovdqu   xmmword ptr [rsp+3F8],xmm0
       mov       rcx,[rsp+3F8]
       mov       ecx,[rcx]
       mov       [rsp+0CF0],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+3E8],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+3E0],rcx
       mov       rcx,[rsp+3E0]
       mov       [rsp+3E8],rcx
       mov       [rsp+3F0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+3E8]
       vmovdqu   xmmword ptr [rsp+3D0],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+3C0],xmm0
       mov       rcx,[rsp+3D0]
       mov       edx,[rsp+3D8]
       mov       [rsp+3B8],rcx
       mov       rcx,[rsp+3B8]
       mov       [rsp+3C0],rcx
       mov       [rsp+3C8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+3C0]
       vmovdqu   xmmword ptr [rsp+3A8],xmm0
       cmp       dword ptr [rsp+3B0],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+3A8]
       vmovdqu   xmmword ptr [rsp+398],xmm0
       mov       rcx,[rsp+398]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CF4],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CF6],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+388],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+378],xmm0
       mov       rcx,[rsp+388]
       mov       edx,[rsp+390]
       mov       [rsp+370],rcx
       mov       rcx,[rsp+370]
       mov       [rsp+378],rcx
       mov       [rsp+380],edx
       vmovdqu   xmm0,xmmword ptr [rsp+378]
       vmovdqu   xmmword ptr [rsp+360],xmm0
       cmp       dword ptr [rsp+368],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+360]
       vmovdqu   xmmword ptr [rsp+350],xmm0
       mov       rcx,[rsp+350]
       mov       ecx,[rcx]
       mov       [rsp+0CF8],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+340],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+338],rcx
       mov       rcx,[rsp+338]
       mov       [rsp+340],rcx
       mov       [rsp+348],edx
       vmovdqu   xmm0,xmmword ptr [rsp+340]
       vmovdqu   xmmword ptr [rsp+328],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+318],xmm0
       mov       rcx,[rsp+328]
       mov       edx,[rsp+330]
       mov       [rsp+310],rcx
       mov       rcx,[rsp+310]
       mov       [rsp+318],rcx
       mov       [rsp+320],edx
       vmovdqu   xmm0,xmmword ptr [rsp+318]
       vmovdqu   xmmword ptr [rsp+300],xmm0
       cmp       dword ptr [rsp+308],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+300]
       vmovdqu   xmmword ptr [rsp+2F0],xmm0
       mov       rcx,[rsp+2F0]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0CFC],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0CFE],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+2E0],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+2D0],xmm0
       mov       rcx,[rsp+2E0]
       mov       edx,[rsp+2E8]
       mov       [rsp+2C8],rcx
       mov       rcx,[rsp+2C8]
       mov       [rsp+2D0],rcx
       mov       [rsp+2D8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+2D0]
       vmovdqu   xmmword ptr [rsp+2B8],xmm0
       cmp       dword ptr [rsp+2C0],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+2B8]
       vmovdqu   xmmword ptr [rsp+2A8],xmm0
       mov       rcx,[rsp+2A8]
       mov       ecx,[rcx]
       mov       [rsp+0D00],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+298],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+290],rcx
       mov       rcx,[rsp+290]
       mov       [rsp+298],rcx
       mov       [rsp+2A0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+298]
       vmovdqu   xmmword ptr [rsp+280],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+270],xmm0
       mov       rcx,[rsp+280]
       mov       edx,[rsp+288]
       mov       [rsp+268],rcx
       mov       rcx,[rsp+268]
       mov       [rsp+270],rcx
       mov       [rsp+278],edx
       vmovdqu   xmm0,xmmword ptr [rsp+270]
       vmovdqu   xmmword ptr [rsp+258],xmm0
       cmp       dword ptr [rsp+260],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+258]
       vmovdqu   xmmword ptr [rsp+248],xmm0
       mov       rcx,[rsp+248]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0D04],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D06],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+238],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+228],xmm0
       mov       rcx,[rsp+238]
       mov       edx,[rsp+240]
       mov       [rsp+220],rcx
       mov       rcx,[rsp+220]
       mov       [rsp+228],rcx
       mov       [rsp+230],edx
       vmovdqu   xmm0,xmmword ptr [rsp+228]
       vmovdqu   xmmword ptr [rsp+210],xmm0
       cmp       dword ptr [rsp+218],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+210]
       vmovdqu   xmmword ptr [rsp+200],xmm0
       mov       rcx,[rsp+200]
       mov       ecx,[rcx]
       mov       [rsp+0D08],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1F0],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+1E8],rcx
       mov       rcx,[rsp+1E8]
       mov       [rsp+1F0],rcx
       mov       [rsp+1F8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+1F0]
       vmovdqu   xmmword ptr [rsp+1D8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1C8],xmm0
       mov       rcx,[rsp+1D8]
       mov       edx,[rsp+1E0]
       mov       [rsp+1C0],rcx
       mov       rcx,[rsp+1C0]
       mov       [rsp+1C8],rcx
       mov       [rsp+1D0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+1C8]
       vmovdqu   xmmword ptr [rsp+1B0],xmm0
       cmp       dword ptr [rsp+1B8],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+1B0]
       vmovdqu   xmmword ptr [rsp+1A0],xmm0
       mov       rcx,[rsp+1A0]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0D0C],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D0E],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+190],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+180],xmm0
       mov       rcx,[rsp+190]
       mov       edx,[rsp+198]
       mov       [rsp+178],rcx
       mov       rcx,[rsp+178]
       mov       [rsp+180],rcx
       mov       [rsp+188],edx
       vmovdqu   xmm0,xmmword ptr [rsp+180]
       vmovdqu   xmmword ptr [rsp+168],xmm0
       cmp       dword ptr [rsp+170],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+168]
       vmovdqu   xmmword ptr [rsp+158],xmm0
       mov       rcx,[rsp+158]
       mov       ecx,[rcx]
       mov       [rsp+0D10],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+148],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+140],rcx
       mov       rcx,[rsp+140]
       mov       [rsp+148],rcx
       mov       [rsp+150],edx
       vmovdqu   xmm0,xmmword ptr [rsp+148]
       vmovdqu   xmmword ptr [rsp+130],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+120],xmm0
       mov       rcx,[rsp+130]
       mov       edx,[rsp+138]
       mov       [rsp+118],rcx
       mov       rcx,[rsp+118]
       mov       [rsp+120],rcx
       mov       [rsp+128],edx
       vmovdqu   xmm0,xmmword ptr [rsp+120]
       vmovdqu   xmmword ptr [rsp+108],xmm0
       cmp       dword ptr [rsp+110],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+108]
       vmovdqu   xmmword ptr [rsp+0F8],xmm0
       mov       rcx,[rsp+0F8]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0D14],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D16],cl
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+0E8],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0D8],xmm0
       mov       rcx,[rsp+0E8]
       mov       edx,[rsp+0F0]
       mov       [rsp+0D0],rcx
       mov       rcx,[rsp+0D0]
       mov       [rsp+0D8],rcx
       mov       [rsp+0E0],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0D8]
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       cmp       dword ptr [rsp+0C8],4
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+0C0]
       vmovdqu   xmmword ptr [rsp+0B0],xmm0
       mov       rcx,[rsp+0B0]
       mov       ecx,[rcx]
       mov       [rsp+0D18],ecx
       cmp       dword ptr [rsp+0C88],4
       jb        near ptr M00_L05
       mov       rcx,[rsp+0C80]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0A0],xmm0
       mov       edx,[rsp+0C88]
       add       edx,0FFFFFFFC
       add       rcx,4
       mov       [rsp+98],rcx
       mov       rcx,[rsp+98]
       mov       [rsp+0A0],rcx
       mov       [rsp+0A8],edx
       vmovdqu   xmm0,xmmword ptr [rsp+0A0]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+78],xmm0
       mov       rcx,[rsp+88]
       mov       edx,[rsp+90]
       mov       [rsp+70],rcx
       mov       rcx,[rsp+70]
       mov       [rsp+78],rcx
       mov       [rsp+80],edx
       vmovdqu   xmm0,xmmword ptr [rsp+78]
       vmovdqu   xmmword ptr [rsp+60],xmm0
       cmp       dword ptr [rsp+68],2
       jl        near ptr M00_L06
       vmovdqu   xmm0,xmmword ptr [rsp+60]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rcx,[rsp+50]
       movzx     ecx,word ptr [rcx]
       mov       [rsp+0D1C],cx
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D1E],cl
       lea       rcx,[rsp+0C70]
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C70]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D20],eax
       cmp       dword ptr [rsp+0C88],4
       jae       short M00_L04
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
M00_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+40],xmm0
       mov       rcx,[rsp+0C80]
       mov       edx,4
       call      Internal.Runtime.CompilerServices.Unsafe.Add[[System.Byte, System.Private.CoreLib]](Byte ByRef, Int32)
       mov       rdx,rax
       mov       r8d,[rsp+0C88]
       add       r8d,0FFFFFFFC
       lea       rcx,[rsp+40]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rsp+40]
       vmovdqu   xmmword ptr [rsp+0C60],xmm0
       lea       rcx,[rsp+0C50]
       vmovdqu   xmm0,xmmword ptr [rsp+0C60]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C50]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D24],ax
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D26],cl
       lea       rcx,[rsp+0C40]
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C40]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D28],eax
       lea       rcx,[rsp+0C80]
       lea       rdx,[rsp+0C30]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0C20]
       vmovdqu   xmm0,xmmword ptr [rsp+0C30]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C20]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D2C],ax
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D2E],cl
       lea       rcx,[rsp+0C10]
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0C10]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D30],eax
       lea       rcx,[rsp+0C80]
       lea       rdx,[rsp+0C00]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0BF0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C00]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BF0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D34],ax
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D36],cl
       lea       rcx,[rsp+0BE0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BE0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D38],eax
       lea       rcx,[rsp+0C80]
       lea       rdx,[rsp+0BD0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0BC0]
       vmovdqu   xmm0,xmmword ptr [rsp+0BD0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BC0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D3C],ax
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D3E],cl
       lea       rcx,[rsp+0BB0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0BB0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D40],eax
       lea       rcx,[rsp+0C80]
       lea       rdx,[rsp+0BA0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0B90]
       vmovdqu   xmm0,xmmword ptr [rsp+0BA0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B90]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D44],ax
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D46],cl
       lea       rcx,[rsp+0B80]
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B80]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D48],eax
       lea       rcx,[rsp+0C80]
       lea       rdx,[rsp+0B70]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0B60]
       vmovdqu   xmm0,xmmword ptr [rsp+0B70]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B60]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D4C],ax
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D4E],cl
       lea       rcx,[rsp+0B50]
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B50]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D50],eax
       lea       rcx,[rsp+0C80]
       lea       rdx,[rsp+0B40]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0B30]
       vmovdqu   xmm0,xmmword ptr [rsp+0B40]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B30]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D54],ax
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D56],cl
       lea       rcx,[rsp+0B20]
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B20]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D58],eax
       lea       rcx,[rsp+0C80]
       lea       rdx,[rsp+0B10]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0B00]
       vmovdqu   xmm0,xmmword ptr [rsp+0B10]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0B00]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D5C],ax
       cmp       dword ptr [rsp+0C88],6
       jbe       near ptr M00_L07
       mov       rcx,[rsp+0C80]
       movzx     ecx,byte ptr [rcx+6]
       mov       [rsp+0D5E],cl
       lea       rcx,[rsp+0AF0]
       vmovdqu   xmm0,xmmword ptr [rsp+0C80]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0AF0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D60],eax
       lea       rcx,[rsp+0C80]
       lea       rdx,[rsp+0AE0]
       mov       r8d,4
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       lea       rcx,[rsp+0AD0]
       vmovdqu   xmm0,xmmword ptr [rsp+0AE0]
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       rdx,[rsp+30]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       vmovdqu   xmm0,xmmword ptr [rsp+0AD0]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(System.ReadOnlySpan`1<Byte>)
       mov       [rsp+0D64],ax
       cmp       dword ptr [rsp+0C88],6
       jbe       short M00_L07
       mov       rdx,[rsp+0C80]
       movzx     edx,byte ptr [rdx+6]
       mov       [rsp+0D66],dl
       inc       edi
       cmp       edi,44521
       jl        near ptr M00_L03
       mov       rcx,rsi
       lea       rdx,[rsp+0CA0]
       mov       r8d,0C8
       call      CORINFO_HELP_MEMCPY
       mov       rax,rsi
       add       rsp,0D68
       pop       rsi
       pop       rdi
       ret
M00_L05:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M00_L06:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 8367
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
       jl        short M02_L00
       mov       eax,[rax]
       add       rsp,28
       ret
M02_L00:
       mov       ecx,28
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 33
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
```assembly
; System.Span`1[[System.Byte, System.Private.CoreLib]].Slice(Int32)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       r8d,eax
       ja        short M06_L00
       mov       rcx,[rcx]
       sub       eax,r8d
       movsxd    r8,r8d
       add       rcx,r8
       mov       [rdx],rcx
       mov       [rdx+8],eax
       mov       rax,rdx
       add       rsp,28
       ret
M06_L00:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
; Total bytes of code 44
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException()

