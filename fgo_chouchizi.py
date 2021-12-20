import emulator_ios as eml
import logger
import sys
import time

chouchizi_mouse_dict={
    'click':(362,432),  # 抽池子按钮350,434
    'reset':(1130,240), # 重置按钮
    'check':(830,560),  # 提示框1
    'confirm':(630,560),  # 提示框2
    'confirm':(725,560),
    'width':1280,  # width of mouse setting
    'height':720 ,  # height of mouse setting
}

chouchizi_mouse_dict_ios={
    'click':(307,306),  # 抽池子按钮350,434
    'reset':(780,176), # 重置按钮
    'check':(575,396),  # 提示框1
    'confirm':(445,389),  # 提示框2
    'width':904,  # width of mouse setting
    'height':591,  # height of mouse setting
}
chouchizi_keyboard_dict={

}
class FgoFetchPool:
    """
    抽池子
    分辨率1280*720

    """

    def __init__(self):
        """
        docstring
        """
        self.emulator = eml.Emulator('Wormhole(iPhoneLin)',chouchizi_keyboard_dict ,chouchizi_mouse_dict_ios , 0)
        self.gap = 0.3

    
    def repeat_Fetch(self,repeatTime,mouse_key):
        for i in range( repeatTime ):
            start = 0
            end=0
            print("抽取第"+str(i+1)+"池子")
            while end-start < 21/self.gap :
                time.sleep(self.gap-0.2)
                end+=1
                self.emulator.press_mouse_key('click',2)
                
            self.emulator.press_mouse_key('reset',2)
            time.sleep(1)
            self.emulator.press_mouse_key('check',2)
            time.sleep(1)
            self.emulator.press_mouse_key('confirm',2)
        return None
    
    def repeat_FriendPoint(self,repeatTime,mouse_key):
        for i in range( repeatTime ):
            start = 0
            end=0
            print("抽取第"+str(i+1)+"池子")
            while end-start < 21/self.gap :
                time.sleep(self.gap-0.2)
                end+=1
                self.emulator.press_mouse_key('click',1)
                
            self.emulator.press_mouse_key('reset',1)
            time.sleep(0.2)
            self.emulator.press_mouse_key('check',1)
            time.sleep(0.2)
            self.emulator.press_mouse_key('confirm',1)
        return None
            


if __name__ == '__main__':
    '''
    一次刷取池子数量建议设置在9以下，否则会爆仓白跑
    '''
    fgoF = FgoFetchPool()
    fgoF.repeat_Fetch(2,chouchizi_mouse_dict)