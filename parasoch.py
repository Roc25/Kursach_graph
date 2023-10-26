reb = [ [0,1], [0,6], [1,0], [1, 2], [1,4], [2,1], [4, 1], [4,5],[4,6],[5,4],[5,6],[6,0],[6,4],[6,5] ]

good = []

def delet(v, mas, g):
    nmas = []
    for i in range(len(mas)):
        if not ((v[0] in mas[i]) or (v[1] in mas[i])):
            nmas.append(mas[i].copy())
    g.append(v.copy())
    if nmas == []:
        return g
    for i in nmas:
        return delet(i.copy(), nmas.copy(), g)



for i in reb:
    good.append(delet(i, reb, []) )

for i in good:
    print(i)

input()