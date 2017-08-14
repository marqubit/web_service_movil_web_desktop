def convolucion(self):
    pixeles = self.imActual.load()
    imCon = Image.new("L", (self.w, self.h))
    conPix = imCon.load()
    h = [(0,0.2,0), (0.2,0.2,0.2), (0,0.2,0)]

    for x in range(self.h):
        for y in range(self.w):
            suma = 0
            for i in range(3):
                for j in range (3):
                    try:
                        if x < self.w or y < self.h:
                            suma += int(pixeles[(x-1)+i,(y-1)+j] * h[j][i])
                    except IndexError:
                        suma += 0
                    print suma                                                 
            conPix[x,y] = suma
        imCon.save('convolusion.png')
        self.imActual = imCon
        self.actualizarFondo()

def convolucion(self):
 pixeles = self.imActual.load()
 imCon = Image.new("L", (self.w, self.h))
 conPix = imCon.load()
        h = [(0,0.2,0), (0.2,0.2,0.2), (0,0.2,0)]
 
        for x in range(self.h):
            for y in range(self.w):
         suma = 0
  for i in range(3):
                    for j in range (3):
   try:
                            if x < self.w or y < self.h:
                                suma += int(pixeles[(x-1)+i,(y-1)+j] * h[j][i])
                        except IndexError:
                            suma += 0
                    #print suma                                                 
                    conPix[x,y] = suma
        imCon.save('convolusion.png')
        self.imActual = imCon
        self.actualizarFondo()