﻿

## **1. 배경 색 변환 기능**
 - 야우스비트와 동일한 배경 색 변환 추가 
 - 알파값 96%의 **(Background.png)** 아래 레이어에 추가해주면 됨

## **2. 무작위 발생값**
- '무작위 발생값' 이라고 명시한 값들은 내가 돌려보면서 수정해나가고 싶은 값들임
 - '무작위 발생값' 이라고 명시된 값들은 **최소값, 최대값 = 즉 발생 가능한 범위** 를 유니티에서 수정할 수 있게 해 줬으면 좋겠음
 
## **3. 배경 스크롤 기능**
 - **Background.png** 스크롤
 - **(스크롤 속도)** 를 무작위 발생값으로 가짐 
- 가로, 세로 방향 둘 다 되면 좋으나 안되면 가로만 해도 무방

## 4. 유성우 비주얼
 - 배경에 무작위로 떨어지는 유성우 비주얼 **(Starfall.png)**
 - 유성우가 생성될 때 마다 **(다음 유성우 생성까지의 딜레이)** 값이 무작위로 정해짐 
 - 유성우는 **(스케일), (낙하 속도),(발생 x좌표)** 를 무작위 발생값으로 가짐

## 5. 스테이지 선택창
- 스테이지 아이콘 이미지 업데이트 **(Select_stage_closed.png), (Select_stage_opened.png)**
- 스테이지 아이콘 내 폰트 나눔스퀘어 적용
- 스테이지 아이콘간 간격 조절 어케하노
- 10스테이지 단위로 좌 우 이동 가능한 화살표 버튼 추가

- **스테이지 아이콘들이 각자 상하 반복 이동을 반복하는 연출**

  무작위 발생값이 스테이지 선택 씬 돌입 시 **각 아이콘마다 정해지며** 변경되지 않음
-  무작위 발생값 : **(총 이동 거리), (이동 속도)**

## **6. 인게임**
- **(공전 속도)** 유니티 어디서 조절하노
- 인게임 확인을 제대로 못해서 아직 뭘 더 추가하고 수정할 지 파악 못 한 상태

## **7. 사용 아이템 추가**
필드에서 주워서 아이템 슬롯을 터치 / 클릭해 사용할 수 있습니다. 

- **추가 아이템 : 힌트**
	젬과 포탈이 있는 방향에 화살표가 표시됩니다. (뭐가 뭔지는 따로 표시 안함)
- **추가 아이템 : 슬로우**
	공전 속도와 타이머 속도가 (SlowValue)% 만큼 감소합니다.
- **추가 아이템 : 가속**
	공전 속도만 (BoostValue)% 만큼 증가합니다.


- **추가 오브젝트 :** 특정 구간 반복 이동을 반복하는 **벽**
	**(가로/세로 이동 방향)**과 **(이동 칸 간격)** 값을 가집니다.
	(이동 속도)를 유니티에서 수정할 수 있으면 좋을듯
- **추가 오브젝트 :** 특정 구간 반복 이동을 반복하는 **데스 존**
**(가로/세로 이동 방향)**과 **(이동 칸 간격)** 값을 가집니다.
	(이동 속도)를 유니티에서 수정할 수 있으면 좋을듯

> *리소스 및 Ui 추가 전달 예정*

## **8. 젬 먹을 때 이펙트**
- 젬 스프라이트의 스케일 증가와 페이드 아웃이 동시에 일어났으면 좋겠음
- **(스케일 증가값)**과 **(Fadetime)**이 수정 가능했으면 좋겠음

