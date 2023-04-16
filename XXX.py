boss_subid = {}
boss_subname = {}
boss_identifier = []

with open('TextFile1.txt', 'r') as f:
    line = f.readline().strip()
    while line != 'END':
        boss_name = ''
        sub_name = ''
        if len(line.split()) == 1:
            boss_id = line.strip()
            boss_name = ''
        else:
            boss_id = line.split()[0]
            for i in line.split()[1:]:
                boss_name = boss_name + " " + i
        line = f.readline()
        
        if len(line.split()) == 1:
            sub_id = line.strip()
            sub_name = ''    
        else:
            sub_id = line.split()[0]
            for i in line.split()[1:]:
                sub_name = sub_name + " " + i
        boss_name = boss_name.strip()
        sub_name = sub_name.strip()
        boss_subid.setdefault(boss_id, []).append((sub_id, sub_name))
        boss_subname.setdefault(boss_name, []).append((sub_id, sub_name))
        line = f.readline().strip()
    line = f.readline().strip()
    boss_identifier.append(line)

subs = []

for boss in boss_identifier:
    for sub in boss_subid.get(boss, []):
        sub_id, sub_name = sub
        if sub_name == '':
            sub_name = 'Unknown Name'
        subs.append((sub_id, sub_name))
        boss_identifier.append(sub_id.strip())
    
    for sub in boss_subname.get(boss, []):
        sub_id, sub_name = sub
        if sub_name == '':
            sub_name = 'Unknown Name'
        subs.append((sub_id, sub_name))
        boss_identifier.append(sub_id.strip())

subs.sort(key=lambda x: int(x[0]))

with open('output.txt', 'w') as f:
    if subs:
        for sub in subs:
            f.write(sub[0] + ' ' + sub[1] + '\n')
    else:
        f.write('NO\n')
