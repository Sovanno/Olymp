import math
Predlogenie = input()
tau_predl = Predlogenie.split()
norm_predl = []
norm_slovo = []
otvet = []

def split(i):
    return [char for char in i]


El = math.floor(len(tau_predl) / 2)
for i in range(len(tau_predl)):
    if i % 2 == 0:
        norm_predl.append(tau_predl[El + i])
        El = El + i
    else:
        norm_predl.append(tau_predl[El - i])
        El = El - i

for i in norm_predl:
    slovo = split(i)
    El = math.floor(len(slovo) / 2)
    for j in range(len(slovo)):
        if j % 2 == 0:
            norm_slovo.append(slovo[El + j])
            El = El + j
        else:
            norm_slovo.append(slovo[El - j])
            El = El - j
    norm_slovo.append(' ')
    sbor_slova = ''.join(norm_slovo)
    norm_slovo = []
    otvet.append(sbor_slova)

print(''.join(otvet))
