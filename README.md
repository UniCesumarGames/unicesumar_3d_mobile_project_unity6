<p align="center">
  <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSm1Z7752bOKmBssX_FeVMtjmgG9ghBpxjfvA9DsNsGkQ&s=10" alt="UniCesumar" height="90">
</p>

<h1 align="center">Projeto 3D Mobile — Unity 6</h1>
<p align="center"><em>Material de aula — personagem 3D, câmera e NPC (UniCesumar)</em></p>

---

## Para que serve este repositório?

Projeto **3D para mobile/desktop** em **Unity 6**, com:

- Movimento do player via `CharacterController` + **Input System**
- Rotação suave olhando para a direção do movimento
- NPC com **NavMesh** (`NPC_Ai.cs`): patrulha e ataque ao detectar o player
- Pacotes de personagens/cenários (Giant, Axe Warrior, RPGPP, etc.) para estudo visual

## Tecnologias

| Item | Detalhe |
|------|---------|
| Engine | **Unity 6** (`6000.1.12f1`) |
| Linguagem | C# |
| IA | NavMeshAgent |
| Input | Input System |

## Estrutura principal

```
Assets/
├── Scripts/
│   ├── PlayerMovement.cs
│   └── NPC_Ai.cs
├── Scenes/
│   ├── SampleScene.unity
│   └── New Scene.unity
├── Modelos/ ...
└── Kevin Iglesias/ ...   # demos de animação
```

## Como abrir (aluno)

1. Unity Hub + **6000.1.12f1**  
2. Clone:
   ```bash
   git clone https://github.com/UniCesumarGames/unicesumar_3d_mobile_project_unity6.git
   ```
3. Abra `Assets/Scenes/SampleScene.unity` (ou a cena indicada pelo professor)  
4. **Play**

## Controles

| Ação | Teclas |
|------|--------|
| Mover | W A S D / setas |

## Checklist de aula

- [ ] Player anda relativo à câmera  
- [ ] Gravidade via `CharacterController.Move`  
- [ ] NPC percorre waypoints  
- [ ] Ao detectar player, NPC para e ataca (Animator)

## Atenção

Projeto pesado (assets 3D). Use SSD e aguarde a importação completa antes de Play.

---

<p align="center">UniCesumar — Jogos Digitais / Desenvolvimento de Games</p>
