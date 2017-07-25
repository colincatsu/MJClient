
›‚
P_Protocol.protoAdoter.AssetP_Asset.proto"_
Account
username (
password (0
account_type (2.Adoter.Asset.ACCOUNT_TYPE"`

PaiElement*
	card_type (2.Adoter.Asset.CARD_TYPE

card_value (

card_index ("e
ItemElement4
inventory_type (2.Adoter.Asset.INVENTORY_TYPE
index (
	global_id ("Ú
User&
account (2.Adoter.Asset.Account
player_list (5
wechat_token (2.Adoter.Asset.WechatAccessToken)
wechat (2.Adoter.Asset.WechatUnion3
client_info (2.Adoter.Asset.ClientInfomation"á

PlayerProp-
position (2.Adoter.Asset.POSITION_TYPE
room_id (0
	load_type (2.Adoter.Asset.LOAD_SCENE_TYPE5
game_oper_state (2.Adoter.Asset.GAME_OPER_TYPE
pai_oper_count (

has_tinged ("§

GameRecord2
list (2$.Adoter.Asset.GameRecord.GameElementä
GameElement
	player_id (
nickname (

headimgurl (
score (C
details (22.Adoter.Asset.GameRecord.GameElement.DetailElementH
DetailElement
score ((
fan_type (2.Adoter.Asset.FAN_TYPE"‡
RoomHistory
room_id (
create_time (*
options (2.Adoter.Asset.RoomOptions&
list (2.Adoter.Asset.GameRecord"µ

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
score ("•
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

time_stamp ("/
Location
	longitude (
latitude ("s
ClientInfomation
	client_ip (
system (

phone_type ((
location (2.Adoter.Asset.Location"Ã
Mail
title (E
send_player (:0\347\263\273\347\273\237\351\202\256\344\273\266
content (
	send_time (
readed (1
attachments (2.Adoter.Asset.MailAttachment"Ñ
Player-
common_prop (2.Adoter.Asset.CommonProp
account (
	server_id (*
	inventory (2.Adoter.Asset.Inventory5
common_limit (2.Adoter.Asset.PlayerCommonLimit/
	cool_down (2.Adoter.Asset.PlayerCoolDown

login_time (
logout_time (
	sign_time	 (
mail_list_system
 (0
mail_list_customized (2.Adoter.Asset.Mail1
game_setting (2.Adoter.Asset.PlayerSetting
room_history (
room_id ("¨
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
account (2.Adoter.Asset.Account"„
WechatAccessToken
access_token (

expires_in (
refresh_token (
openid (
scope (
unionid (".
WechatError
errcode (
errmsg ("g
WechatLoginC
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_WECHAT_LOGIN
access_code ("
SwitchAccountE
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_SWITCH_ACCOUNT
account_name (
	player_id ("¥
WechatUnion
openid (
nickname (
sex (
province (
city (
country (

headimgurl (
	privilege (
unionid	 ("G
Logout=
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_LOGOUT"a
	EnterGameA
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_ENTER_GAME
	player_id ("”
UpdateClientDataK
type_t (2.Adoter.Asset.META_TYPE:"META_TYPE_SHARE_UPDATE_CLIENT_DATA3
client_info (2.Adoter.Asset.ClientInfomation"¼

SystemChatD
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_SYSTEM_CHAT*
	chat_type (2.Adoter.Asset.CHAT_TYPE-
position (2.Adoter.Asset.POSITION_TYPE
index ("‡
Room
room_id (*
	room_type (2.Adoter.Asset.ROOM_TYPE
enter_password (*
options (2.Adoter.Asset.RoomOptions"t

CreateRoomD
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_CREATE_ROOM 
room (2.Adoter.Asset.Room"“
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
result ("¥
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
account ("b
PlayerSetting
music (:true
voice (:true
audio (:true

click_push ("‡
GameSettingE
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_GAME_SETTING1
game_setting (2.Adoter.Asset.PlayerSetting"û
	GetRewardA
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_GET_REWARD9
reason (2).Adoter.Asset.GetReward.GET_REWARD_REASON
	reward_id ("]
GET_REWARD_REASON!
GET_REWARD_REASON_DAILY_BONUS%
!GET_REWARD_REASON_DAILY_ALLOWANCE"§
PaiOperationLimit
	player_id (
from_player_id (
time_out (%
pai (2.Adoter.Asset.PaiElement.
	oper_type (2.Adoter.Asset.PAI_OPER_TYPE"¦
PaiOperationList
	player_id (
from_player_id (
time_out (%
pai (2.Adoter.Asset.PaiElement.
	oper_list (2.Adoter.Asset.PAI_OPER_TYPE"„
PaiOperationF
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_PAI_OPERATION.
	oper_type (2.Adoter.Asset.PAI_OPER_TYPE-
position (2.Adoter.Asset.POSITION_TYPE&
pais (2.Adoter.Asset.PaiElement%
pai (2.Adoter.Asset.PaiElement"ð
GameOperationG
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_GAME_OPERATION/
	oper_type (2.Adoter.Asset.GAME_OPER_TYPE
source_player_id (
destination_player_id (,

error_code (2.Adoter.Asset.ERROR_CODE"w
BuySomethingF
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_BUY_SOMETHING
mall_id (
result ("’
	LoadSceneA
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_LOAD_SCENE0
	load_type (2.Adoter.Asset.LOAD_SCENE_TYPE
scene_id ("`
	ReConnect@
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_C2S_RECONNECT
	player_id ("Œ

PlayerList>
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_PLAYERS
player_list ()
wechat (2.Adoter.Asset.WechatUnion"}
PlayerInformationB
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_PLAYER_INFO$
player (2.Adoter.Asset.Player"æ
AlertMessageB
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_ALERT_ERROR,

error_type (2.Adoter.Asset.ERROR_TYPE6
error_show_type (2.Adoter.Asset.ERROR_SHOW_TYPE,

error_code (2.Adoter.Asset.ERROR_CODE"½
LiuJu<
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_LIUJU/
elements (2.Adoter.Asset.LiuJu.LJElementE
	LJElement
	player_id (%
pai (2.Adoter.Asset.PaiElement"ˆ
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
CARDS_DATA_TYPE_SYNC"±
SyncCommonPropertyH
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_SHARE_COMMON_PROPERTYF
reason_type (21.Adoter.Asset.SyncCommonProperty.SYNC_REASON_TYPE
	player_id (-
common_prop (2.Adoter.Asset.CommonProp"G
SYNC_REASON_TYPE
SYNC_REASON_TYPE_SELF
SYNC_REASON_TYPE_GET"‚
PaiOperationAlertJ
type_t (2.Adoter.Asset.META_TYPE:!META_TYPE_S2C_PAI_OPERATION_ALERT:
pais (2,.Adoter.Asset.PaiOperationAlert.AlertElemente
AlertElement%
pai (2.Adoter.Asset.PaiElement.
	oper_list (2.Adoter.Asset.PAI_OPER_TYPE"
SyncCommonLimitC
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_COMMON_LIMIT5
common_limit (2.Adoter.Asset.PlayerCommonLimit"r
SyncCommonRewardD
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_COMMON_REWARD
common_reward_id ("ï
RoomInformation@
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_ROOM_INFO9
player_list (2$.Adoter.Asset.RoomInformation.PlayerÞ
Player-
position (2.Adoter.Asset.POSITION_TYPE/
	oper_type (2.Adoter.Asset.GAME_OPER_TYPE-
common_prop (2.Adoter.Asset.CommonProp)
wechat (2.Adoter.Asset.WechatUnionF
dis_list (24.Adoter.Asset.RoomInformation.Player.DistanceElementR
DistanceElement-
position (2.Adoter.Asset.POSITION_TYPE
distance ("ã
GameCalculateE
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_GAME_CALCULATE3
calculte_type (2.Adoter.Asset.CALCULATE_TYPE(
record (2.Adoter.Asset.GameRecord,
max_fan_type (2.Adoter.Asset.FAN_TYPE"¦

RoomRecord
	player_id (
nickname (

headimgurl (
score (
pk_count (
banker_count (
	win_count (
dianpao_count ("€
RoomCalculateE
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_ROOM_CALCULATE(
record (2.Adoter.Asset.RoomRecord"m
GameInformation@
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_GAME_INFO
banker_player_id ("Œ
KickOut?
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_KILL_OUT
	player_id (-
reason (2.Adoter.Asset.KICK_OUT_REASON"È
SyncActivity?
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_ACTIVITYA
activity_list (2*.Adoter.Asset.SyncActivity.ActivityElement4
ActivityElement
activity_id (
open ("š
SystemBroadcastingG
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_SYSTEM_BROADCASTO
broad_cast_type (26.Adoter.Asset.SystemBroadcasting.SYSTEM_BROADCAST_TYPE
content ("Y
SYSTEM_BROADCAST_TYPE 
SYSTEM_BROADCAST_TYPE_SCROLL
SYSTEM_BROADCAST_TYPE_CHAT"H
MultiplePai*
	card_type (2.Adoter.Asset.CARD_TYPE
cards ("‘
PaiPushDownD
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_PAI_PUSH_DOWN<
player_list (2'.Adoter.Asset.PaiPushDown.PlayerElement~
PlayerElement
	player_id (-
position (2.Adoter.Asset.POSITION_TYPE+
pai_list (2.Adoter.Asset.MultiplePai"^
	GamesFullA
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_GAMES_FULL
rounds ("²

WeChatInfoH
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_WECHAT_INFOMATION)
wechat (2.Adoter.Asset.WechatUnion/
wechat_error (2.Adoter.Asset.WechatError"|
	GameStartA
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2C_GAME_START
total_rounds (
current_rounds ("
RegisterServer?
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2S_REGISTER*
	role_type (2.Adoter.Asset.ROLE_TYPE
	global_id ("˜
KickOutPlayerE
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2S_KICKOUT_PLAYER-
reason (2.Adoter.Asset.KICK_OUT_REASON
	player_id ("i
GmtInnerMetaE
type_t (2.Adoter.Asset.META_TYPE:META_TYPE_S2S_GMT_INNER_META

inner_meta (*u
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
#DIAMOND_CHANGED_TYPE_GENERAL_REWARD*„
HUANLEDOU_CHANGED_TYPE
HUANLEDOU_CHANGED_TYPE_GMT
HUANLEDOU_CHANGED_TYPE_MALL)
%HUANLEDOU_CHANGED_TYPE_GENERAL_REWARD*
ROOM_CARD_CHANGED_TYPE
ROOM_CARD_CHANGED_TYPE_GMT
ROOM_CARD_CHANGED_TYPE_MALL$
 ROOM_CARD_CHANGED_TYPE_OPEN_ROOM*‰
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
ERROR_SHOW_TYPE_CHAT*š

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
ERROR_ROOM_CARD_GAMES_FULL
ERROR_GAME_NO_PERMISSION(
ERROR_GAME_PAI_UNSATISFIED)
ERROR_COMMON_REWARD_DATA2
ERROR_COMMON_REWARD_HAS_GOT3*²
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
META_TYPE_SHARE_GUEST_LOGIN 
META_TYPE_SHARE_GAME_SETTING&
"META_TYPE_SHARE_UPDATE_CLIENT_DATA
META_TYPE_SHARE_SYSTEM_CHAT
META_TYPE_SHARE_COUNT2
META_TYPE_C2S_BEGIN3
META_TYPE_C2S_LOGIN4
META_TYPE_C2S_LOGOUT5
META_TYPE_C2S_SELECT_SERVER6
META_TYPE_C2S_ENTER_GAME7
META_TYPE_C2S_GET_REWARD8
META_TYPE_C2S_LOAD_SCENE9
META_TYPE_C2S_RECONNECT:
META_TYPE_C2S_WECHAT_LOGIN; 
META_TYPE_C2S_SWITCH_ACCOUNT<
META_TYPE_C2S_COUNTÿ
META_TYPE_S2C_BEGINõ
META_TYPE_S2C_TICKETö
META_TYPE_S2C_SERVER_LIST÷
META_TYPE_S2C_PLAYERSø
META_TYPE_S2C_PLAYER_INFOù
META_TYPE_S2C_ALERT_ERRORû
META_TYPE_S2C_LIUJUü
META_TYPE_S2C_PAI_NOTIFYý&
!META_TYPE_S2C_PAI_OPERATION_ALERTþ
META_TYPE_S2C_COMMON_LIMITÿ 
META_TYPE_S2C_COMMON_REWARD€
META_TYPE_S2C_ROOM_INFO!
META_TYPE_S2C_GAME_CALCULATE‚
META_TYPE_S2C_GAME_INFOƒ
META_TYPE_S2C_KILL_OUT„
META_TYPE_S2C_ACTIVITY…#
META_TYPE_S2C_SYSTEM_BROADCAST† 
META_TYPE_S2C_PAI_PUSH_DOWN‡
META_TYPE_S2C_GAMES_FULLˆ$
META_TYPE_S2C_WECHAT_INFOMATION‰
META_TYPE_S2C_GAME_STARTŠ!
META_TYPE_S2C_ROOM_CALCULATE‹
META_TYPE_S2C_COUNTè
META_TYPE_S2S_REGISTERé!
META_TYPE_S2S_KICKOUT_PLAYERê!
META_TYPE_S2S_GMT_INNER_METAë*l
ACCOUNT_TYPE
ACCOUNT_TYPE_8HERE
ACCOUNT_TYPE_GUEST
ACCOUNT_TYPE_WECHAT
ACCOUNT_TYPE_QQ*3
	CHAT_TYPE
CHAT_TYPE_TEXT
CHAT_TYPE_FACE*ñ
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
PAI_OPER_TYPE_COUNT*À
GAME_OPER_TYPE
GAME_OPER_TYPE_NULL
GAME_OPER_TYPE_START
GAME_OPER_TYPE_LEAVE
GAME_OPER_TYPE_KICKOUT 
GAME_OPER_TYPE_DISMISS_AGREE#
GAME_OPER_TYPE_DISMISS_DISAGREE*D
CALCULATE_TYPE
CALCULATE_TYPE_HUPAI
CALCULATE_TYPE_LIUJU*
KICK_OUT_REASON
KICK_OUT_REASON_BEGIN 
KICK_OUT_REASON_DISCONNECT
KICK_OUT_REASON_OTHER_LOGIN!
KICK_OUT_REASON_CHANGE_SERVER*<
	ROLE_TYPE
ROLE_TYPE_PLAYER
ROLE_TYPE_GAME_SERVER