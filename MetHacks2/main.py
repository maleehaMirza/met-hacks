import pygame
import sys
from button import Button

pygame.init()
SCREEN = pygame.display.set_mode((1191, 670))
BG = pygame.image.load("greenclues.jpg")

# Set the size for the image
DEFAULT_IMAGE_SIZE = (400, 400)

arrow = pygame.image.load("arrow.png")
arrow = pygame.transform.scale(arrow, (100, 100))

backArrow = arrow.copy()
backArrowCopy = pygame.transform.flip(backArrow, True, False)

def get_font(size): # Returns Press-Start-2P in the desired size
    return pygame.font.Font("font.ttf", size)

def greenieIntro():
    while True:
        # PLAY_MOUSE_POS = pygame.mouse.get_pos()
        
        BG = pygame.image.load("GreenieIntro.png")

        SCREEN.blit(BG, (0, 0))
        """GAME_1 = Button(image=None, pos=(300, 460),text_input="GAME 1", font=get_font(30), base_color="White", hovering_color="#FFB90F")
        GAME_1.changeColor(PLAY_MOUSE_POS)
        GAME_1.update(SCREEN)
        
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                sys.exit()
            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_SPACE:
                    nextPage()

        pygame.display.update() 
        """
        MENU_MOUSE_POS = pygame.mouse.get_pos()
        CONTINUE_BUTTON = Button(image = arrow, pos =(1080, 630), text_input="", font= get_font(50), base_color="White", hovering_color="#6E8B3D")

        for button in [CONTINUE_BUTTON]:    
            button.changeColor(MENU_MOUSE_POS)
            button.update(SCREEN)
        
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                sys.exit()
            if event.type == pygame.MOUSEBUTTONDOWN:
                if CONTINUE_BUTTON.checkForInput(MENU_MOUSE_POS):
                    bobIntro()

        pygame.display.update()
        

def bobIntro():
    while True:
        BG = pygame.image.load("BobIntro.png")

        SCREEN.blit(BG, (0, 0))
        """GAME_1 = Button(image=None, pos=(300, 460),text_input="GAME 1", font=get_font(30), base_color="White", hovering_color="#FFB90F")
        GAME_1.changeColor(PLAY_MOUSE_POS)
        GAME_1.update(SCREEN)"""
        
        MENU_MOUSE_POS = pygame.mouse.get_pos()
        CONTINUE_BUTTON = Button(image = arrow, pos =(1080, 630), text_input="", font= get_font(50), base_color="White", hovering_color="#6E8B3D")
        BACK_BUTTON = Button(image = backArrowCopy, pos =(80, 630), text_input="", font= get_font(50), base_color="White", hovering_color="#6E8B3D")

        for button in [CONTINUE_BUTTON, BACK_BUTTON]:    
            button.changeColor(MENU_MOUSE_POS)
            button.update(SCREEN)
        
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                sys.exit()
            if event.type == pygame.MOUSEBUTTONDOWN:
                if CONTINUE_BUTTON.checkForInput(MENU_MOUSE_POS):
                    storyIntro("First")
                elif BACK_BUTTON.checkForInput(MENU_MOUSE_POS):
                    greenieIntro()

        pygame.display.update()

def storyIntro(type):
     while True:
        if (type == "First"):
            BG = pygame.image.load("Story.png")
        else:
            BG = pygame.image.load("Objective.png")

        SCREEN.blit(BG, (0, 0))
        """GAME_1 = Button(image=None, pos=(300, 460),text_input="GAME 1", font=get_font(30), base_color="White", hovering_color="#FFB90F")
        GAME_1.changeColor(PLAY_MOUSE_POS)
        GAME_1.update(SCREEN)"""
        
        MENU_MOUSE_POS = pygame.mouse.get_pos()
        CONTINUE_BUTTON = Button(image = arrow, pos =(1080, 630), text_input="", font= get_font(50), base_color="White", hovering_color="#6E8B3D")
        BACK_BUTTON = Button(image = backArrowCopy, pos =(80, 630), text_input="", font= get_font(50), base_color="White", hovering_color="#6E8B3D")

        for button in [CONTINUE_BUTTON, BACK_BUTTON]:    
            button.changeColor(MENU_MOUSE_POS)
            button.update(SCREEN)
        
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                sys.exit()
            if event.type == pygame.MOUSEBUTTONDOWN:
                if CONTINUE_BUTTON.checkForInput(MENU_MOUSE_POS):
                    if (type == "First"):
                        storyIntro("Second")
                    else:
                        storyIntro("Second") # CHANGE LATER
                elif BACK_BUTTON.checkForInput(MENU_MOUSE_POS):
                    if (type == "First"):
                       bobIntro()
                    else:
                        storyIntro("First") 

        pygame.display.update()
        

    

        
def main_menu():    
    while True:
        SCREEN.blit(BG, (0, 0))

        MENU_MOUSE_POS = pygame.mouse.get_pos()
        
        PLAY_BUTTON = Button(image = pygame.image.load("Play Rect.png"), pos =(600, 500), text_input="PLAY", font= get_font(50), base_color="White", hovering_color="#6E8B3D")

        for button in [PLAY_BUTTON]:    
            button.changeColor(MENU_MOUSE_POS)
            button.update(SCREEN)
        
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                sys.exit()
            if event.type == pygame.MOUSEBUTTONDOWN:
                if PLAY_BUTTON.checkForInput(MENU_MOUSE_POS):
                    greenieIntro()

        pygame.display.update()
            
main_menu()