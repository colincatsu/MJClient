
„g
P_Protocol.protoAdoter.AssetP_Asset.proto"-
Account
username (
password ("`

PaiElement*
	card_type (2.Adoter.Asset.CARD_TYPE

card_value (

card_index ("e
ItemElement4
inventory_type (2.Adoter.Asset.INVENTORY_TYPE
index (
	global_id ("C
User&
account (2.Adoter.Asset.Account
player_list ("·

PlayerProp-
position (2.Adoter.Asset.POSITION_TYPE
room_id (0
	load_type (2.Adoter.Asset.LOAD_SCENE_TYPE5
game_oper_state (2.Adoter.Asset.GAME_OPER_TYPE
pai_oper_count (

has_tinged ("Å

GameRecord2
list (2$.Adoter.Asset.GameRecord.GameElementæ
GameElement
	player_id (
score (C
details (22.Adoter.Asset.GameRecord.GameElement.DetailElementH
DetailElement
score ((
fan_type (2.Adoter.Asset.FAN_TYPE"[
RoomHistory
room_id (
create_time (&
list (2.Adoter.Asset.GameRecord"µ

CommonProp
	player_id (
local_server_id (
name (
iphoto (
level (:1:
gender (2.Adoter.Asset.GENDER_TYPE:GENDER_TYPE_MAN
diamond (
	huanledou (
room_card_count	 (
total_rounds
 (
total_win_rounds (
streak_wins (
score ("ï
PlayerCommonLimit9
elements (2'.Adoter.Asset.PlayerCommonLimit.ElementE
Element
common_limit_id (

time_stamp (
count ("}
PlayerCoolDown6
elements (2$.Adoter.Asset.PlayerCoolDown.Element3
Element
cool_down_id (

time_stamp ("I
ClientInfomation
	client_ip (
system (

phone_type ("√
Mail
title (E
send_player (:0\347\263\273\347\273\237\351\202\256\344\273\266
content (
	send_time (
readed (1
attachments (2.Adoter.Asset.MailAttachment"ˇ
Player-
common_prop (2.Adoter.Asset.CommonProp
	server_id (*
	inventory (2.Adoter.Asset.Inventory5
common_limit (2.Adoter.Asset.PlayerCommonLimit/
	cool_down (2.Adoter.Asset.PlayerCoolDown

login_time (
logout_time (
	sign_time (3
client_info	 (2.Adoter.Asset.ClientInfomation
mail_list_system
 (0
mail_list_customized (2.Adoter.Asset.Mail1
game_setting (2.Adoter.Asset.PlayerSetting/
room_history (2.Adoter.Asset.RoomHistory"®
	Inventory2
	inventory (2.Adoter.Asset.Inventory.Elementg
Element4
inventory_type (2.Adoter.Asset.INVENTORY_TYPE&
items (2.Adoter.Asset.Item_Item"
ItemEquipment
star ("Q
Meta'
type_t (2.Adoter.Asset.META_TYPE
stuff (
	player_id ("i
CreatePlayerF
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_CREATE_PLAYER
	player_id ("m
Login<
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_LOGIN&
account (2.Adoter.Asset.Account"G
Logout=
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_LOGOUT"a
	EnterGameA
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_ENTER_GAME
	player_id ("á
Room
room_id (*
	room_type (2.Adoter.Asset.ROOM_TYPE
enter_password (*
options (2.Adoter.Asset.RoomOptions"t

CreateRoomD
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_CREATE_ROOM 
room (2.Adoter.Asset.Room"ì
	EnterRoomC
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_ENTER_ROOM 
room (2.Adoter.Asset.Room,

error_code (2.Adoter.Asset.ERROR_CODE6

enter_type (2".Adoter.Asset.EnterRoom.ENTER_TYPE"9

ENTER_TYPE
ENTER_TYPE_ENTER
ENTER_TYPE_CANCEL"V
Sign=
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_SIGN
success ("z
PlayerLuckyPlateD
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_LUCKY_PLATE
plate_id (
result ("•
RandomSaiziE
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_RANDOM_SAIZI:
reason_type (2%.Adoter.Asset.RandomSaizi.REASON_TYPE
random_result (%
pai (2.Adoter.Asset.PaiElement
has_rand_saizi ("=
REASON_TYPE
REASON_TYPE_START
REASON_TYPE_TINGPAI"]
SayHi?
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_SAY_HI
heart_count ("c

GuestLoginD
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_GUEST_LOGIN
account ("P
PlayerSetting
music (
voice (
audio (

click_push ("á
GameSettingE
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_GAME_SETTING1
game_setting (2.Adoter.Asset.PlayerSetting"˚
	GetRewardA
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_GET_REWARD9
reason (2).Adoter.Asset.GetReward.GET_REWARD_REASON
	reward_id ("]
GET_REWARD_REASON!
GET_REWARD_REASON_DAILY_BONUS%
!GET_REWARD_REASON_DAILY_ALLOWANCE"ß
PaiOperationLimit
	player_id (
from_player_id (
time_out (%
pai (2.Adoter.Asset.PaiElement.
	oper_type (2.Adoter.Asset.PAI_OPER_TYPE"¶
PaiOperationList
	player_id (
from_player_id (
time_out (%
pai (2.Adoter.Asset.PaiElement.
	oper_list (2.Adoter.Asset.PAI_OPER_TYPE"Ñ
PaiOperationF
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_PAI_OPERATION.
	oper_type (2.Adoter.Asset.PAI_OPER_TYPE-
position (2.Adoter.Asset.POSITION_TYPE&
pais (2.Adoter.Asset.PaiElement%
pai (2.Adoter.Asset.PaiElement"¬
GameOperationG
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_GAME_OPERATION/
	oper_type (2.Adoter.Asset.GAME_OPER_TYPE
source_player_id (
destination_player_id ("w
BuySomethingF
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_BUY_SOMETHING
mall_id (
result ("í
	LoadSceneA
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_LOAD_SCENE0
	load_type (2.Adoter.Asset.LOAD_SCENE_TYPE
scene_id ("`
	ReConnect@
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_RECONNECT
	player_id ("a

PlayerList>
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_PLAYERS
player_list ("}
PlayerInformationB
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_PLAYER_INFO$
player (2.Adoter.Asset.Player"Ê
AlertMessageB
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_ALERT_ERROR,

error_type (2.Adoter.Asset.ERROR_TYPE6
error_show_type (2.Adoter.Asset.ERROR_SHOW_TYPE,

error_code (2.Adoter.Asset.ERROR_CODE"Ω
LiuJu<
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_LIUJU/
elements (2.Adoter.Asset.LiuJu.LJElementE
	LJElement
	player_id (%
pai (2.Adoter.Asset.PaiElement"à
	PaiNotifyA
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_PAI_NOTIFY
	player_id (:
	data_type (2'.Adoter.Asset.PaiNotify.CARDS_DATA_TYPE-
pais (2.Adoter.Asset.PaiNotify.MutiPai.
pai (2!.Adoter.Asset.PaiNotify.SinglePai
cards_remain (D
MutiPai*
	card_type (2.Adoter.Asset.CARD_TYPE
cards (K
	SinglePai*
	card_type (2.Adoter.Asset.CARD_TYPE

card_value ("a
CARDS_DATA_TYPE
CARDS_DATA_TYPE_START
CARDS_DATA_TYPE_FAPAI
CARDS_DATA_TYPE_SYNC"©
CommonPropertyH
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_COMMON_PROPERTYB
reason_type (2-.Adoter.Asset.CommonProperty.SYNC_REASON_TYPE
	player_id (-
common_prop (2.Adoter.Asset.CommonProp"G
SYNC_REASON_TYPE
SYNC_REASON_TYPE_SELF
SYNC_REASON_TYPE_GET"Ç
PaiOperationAlertJ
type_t (2.Adoter.Asset.META_TYPE:!META_TYPE_S2C_PAI_OPERATION_ALERT:
pais (2,.Adoter.Asset.PaiOperationAlert.AlertElemente
AlertElement%
pai (2.Adoter.Asset.PaiElement.
	oper_list (2.Adoter.Asset.PAI_OPER_TYPE"ç
SyncCommonLimitC
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_COMMON_LIMIT5
common_limit (2.Adoter.Asset.PlayerCommonLimit"r
SyncCommonRewardD
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_COMMON_REWARD
common_reward_id ("ˆ
RoomInformation@
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_ROOM_INFO9
player_list (2$.Adoter.Asset.RoomInformation.Playerf
Player-
position (2.Adoter.Asset.POSITION_TYPE-
common_prop (2.Adoter.Asset.CommonProp"Æ
GameCalculateE
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_GAME_CALCULATE(
record (2.Adoter.Asset.GameRecord,
max_fan_type (2.Adoter.Asset.FAN_TYPE"m
GameInformation@
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_GAME_INFO
banker_player_id ("ê
KillOut?
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_KILL_OUT
	player_id (1

out_reason (2.Adoter.Asset.KILL_OUT_REASON"»
SyncActivity?
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_ACTIVITYA
activity_list (2*.Adoter.Asset.SyncActivity.ActivityElement4
ActivityElement
activity_id (
open ("ö
SystemBroadcastingG
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_SYSTEM_BROADCASTO
broad_cast_type (26.Adoter.Asset.SystemBroadcasting.SYSTEM_BROADCAST_TYPE
content ("Y
SYSTEM_BROADCAST_TYPE 
SYSTEM_BROADCAST_TYPE_SCROLL
SYSTEM_BROADCAST_TYPE_CHAT"H
MultiplePai*
	card_type (2.Adoter.Asset.CARD_TYPE
cards ("ë
PaiPushDownD
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_PAI_PUSH_DOWN<
player_list (2'.Adoter.Asset.PaiPushDown.PlayerElement~
PlayerElement
	player_id (-
position (2.Adoter.Asset.POSITION_TYPE+
pai_list (2.Adoter.Asset.MultiplePai"ê
RegisterServer?
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2S_REGISTER*
	role_type (2.Adoter.Asset.ROLE_TYPE
	global_id (*u
ERR_USE_ITEM_TYPE
ERR_USE_ITEM_TYPE_SUCCESS !
ERR_USE_ITEM_TYPE_LEVEL_BELOW
ERR_USE_ITEM_TYPE_LEVEL_UP*J
ITEM_CHANGED_TYPE
ITEM_CHANGED_TYPE_GMT
ITEM_CHANGED_TYPE_MALL*|
DIAMOND_CHANGED_TYPE
DIAMOND_CHANGED_TYPE_GMT
DIAMOND_CHANGED_TYPE_MALL'
#DIAMOND_CHANGED_TYPE_GENERAL_REWARD*Ñ
HUANLEDOU_CHANGED_TYPE
HUANLEDOU_CHANGED_TYPE_GMT
HUANLEDOU_CHANGED_TYPE_MALL)
%HUANLEDOU_CHANGED_TYPE_GENERAL_REWARD*
ROOM_CARD_CHANGED_TYPE
ROOM_CARD_CHANGED_TYPE_GMT
ROOM_CARD_CHANGED_TYPE_MALL$
 ROOM_CARD_CHANGED_TYPE_OPEN_ROOM*â
POSITION_TYPE
POSITION_TYPE_NULL 
POSITION_TYPE_EAST
POSITION_TYPE_SOUTH
POSITION_TYPE_WEST
POSITION_TYPE_NORTH*
LOAD_SCENE_TYPE
LOAD_SCENE_TYPE_NULL
LOAD_SCENE_TYPE_START
LOAD_SCENE_TYPE_SUCCESS
LOAD_SCENE_TYPE_FAILED*B

ERROR_TYPE
ERROR_TYPE_NORMAL
ERROR_TYPE_INVENTORY_FULL*+
ERROR_SHOW_TYPE
ERROR_SHOW_TYPE_CHAT*˙

ERROR_CODE
ERROR_SUCCESS 
ERROR_INNER
ERROR_DIAMOND_NOT_ENOUGH
ERROR_HUANLEDOU_NOT_ENOUGH
ERROR_INVENTORY_FULL
ERROR_REWARD_HAS_GOT
ERROR_HUANLEDOU_LIMIT
ERROR_MALL_NOT_FOUND
ERROR_ACTIVITY_NOT_OPEN
ERROR_CLIENT_DATA	
ERROR_HAS_NO_PLAYER

ERROR_DATABASE
ERROR_ROOM_CARD_NOT_ENOUGH
ERROR_ROOM_NOT_FOUNT
ERROR_ROOM_PASSWORD
ERROR_ROOM_IS_FULL
ERROR_ROOM_NOT_AVAILABLE
ERROR_ROOM_NO_PERMISSION
ERROR_ROOM_BEANS_MIN_LIMIT
ERROR_ROOM_BEANS_MAX_LIMIT
ERROR_ROOM_TYPE_NOT_FOUND
ERROR_ROOM_HAS_BEEN_IN!
ERROR_ROOM_GUEST_FORBID_ENTER
ERROR_GAME_NO_PERMISSION(
ERROR_GAME_PAI_UNSATISFIED)
ERROR_COMMON_REWARD_DATA2
ERROR_COMMON_REWARD_HAS_GOT3*€

	META_TYPE
META_TYPE_SHARE_BEGIN!
META_TYPE_SHARE_CREATE_PLAYER
META_TYPE_SHARE_CREATE_ROOM!
META_TYPE_SHARE_PAI_OPERATION"
META_TYPE_SHARE_GAME_OPERATION#
META_TYPE_SHARE_COMMON_PROPERTY!
META_TYPE_SHARE_BUY_SOMETHING
META_TYPE_SHARE_ENTER_ROOM
META_TYPE_SHARE_SIGN	
META_TYPE_SHARE_LUCKY_PLATE
 
META_TYPE_SHARE_RANDOM_SAIZI
META_TYPE_SHARE_SAY_HI
META_TYPE_SHARE_GUEST_LOGIN!
META_TYPE_SHARE_GAME_SETTINGà
META_TYPE_SHARE_COUNT2
META_TYPE_C2S_BEGIN3
META_TYPE_C2S_LOGIN4
META_TYPE_C2S_LOGOUT5
META_TYPE_C2S_SELECT_SERVER6
META_TYPE_C2S_ENTER_GAME7
META_TYPE_C2S_GET_REWARD8
META_TYPE_C2S_LOAD_SCENE9
META_TYPE_C2S_RECONNECT:
META_TYPE_C2S_COUNTˇ
META_TYPE_S2C_BEGINı
META_TYPE_S2C_TICKETˆ
META_TYPE_S2C_SERVER_LIST˜
META_TYPE_S2C_PLAYERS¯
META_TYPE_S2C_PLAYER_INFO˘
META_TYPE_S2C_ALERT_ERROR˚
META_TYPE_S2C_LIUJU¸
META_TYPE_S2C_PAI_NOTIFY˝&
!META_TYPE_S2C_PAI_OPERATION_ALERT˛
META_TYPE_S2C_COMMON_LIMITˇ 
META_TYPE_S2C_COMMON_REWARDÄ
META_TYPE_S2C_ROOM_INFOÅ!
META_TYPE_S2C_GAME_CALCULATEÇ
META_TYPE_S2C_GAME_INFOÉ
META_TYPE_S2C_KILL_OUTÑ
META_TYPE_S2C_ACTIVITYÖ#
META_TYPE_S2C_SYSTEM_BROADCASTÜ 
META_TYPE_S2C_PAI_PUSH_DOWNá
META_TYPE_S2C_COUNTË
META_TYPE_S2S_REGISTERÈ*Ò
PAI_OPER_TYPE
PAI_OPER_TYPE_BEGIN 
PAI_OPER_TYPE_DAPAI
PAI_OPER_TYPE_HUPAI
PAI_OPER_TYPE_GANGPAI
PAI_OPER_TYPE_PENGPAI
PAI_OPER_TYPE_CHIPAI
PAI_OPER_TYPE_GIVEUP
PAI_OPER_TYPE_XUANFENG_FENG
PAI_OPER_TYPE_XUANFENG_JIAN
PAI_OPER_TYPE_ANGANGPAI	
PAI_OPER_TYPE_TINGPAI

PAI_OPER_TYPE_BAOPAI
PAI_OPER_TYPE_COUNT*y
GAME_OPER_TYPE
GAME_OPER_TYPE_NULL
GAME_OPER_TYPE_START
GAME_OPER_TYPE_LEAVE
GAME_OPER_TYPE_KICKOUT*M
KILL_OUT_REASON
KILL_OUT_REASON_BEGIN 
KILL_OUT_REASON_OTHER_LOGIN*<
	ROLE_TYPE
ROLE_TYPE_PLAYER
ROLE_TYPE_GAME_SERVER