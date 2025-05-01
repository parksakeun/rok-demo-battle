# ROK Demo Battle

🛡 Unity RTS 전투 데모 프로젝트

## 구성
- `CommanderMovement.cs`: 마우스 클릭 → 유닛 이동
- `CombatSystem.cs`: 충돌 시 자동으로 데미지를 주고 받음
- `BattleScene`: Plane 위에서 Cube 유닛들이 싸움

## 사용 방법
1. Unity Hub에서 이 저장소 폴더 열기
2. `Scenes/BattleScene` 생성
3. Plane + Cube 배치
   - Cube에 NavMeshAgent 추가
   - 두 스크립트(CommanderMovement, CombatSystem) 추가
4. Window → AI → Navigation → Plane에 Bake
5. ▶ 실행 → 마우스 클릭으로 이동 + 충돌 시 전투
